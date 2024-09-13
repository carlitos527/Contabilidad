using System;
using System.Configuration;
using System.Windows.Forms;
using PollosWeed.Repositories;

namespace PollosWeed
{
    public partial class InsumosForm : Form
    {
        private readonly InsumosRepository _insumosRepository;
        private int selectedId = 0; // Para almacenar el Id del registro seleccionado.
        private int pollosId = 1; // Ajusta según cómo obtienes este valor en tu aplicación.
        private int insumosId = 1; // Ajusta según cómo obtienes este valor en tu aplicación.

        public InsumosForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"]?.ConnectionString; // Reemplaza con tu cadena de conexión.
            _insumosRepository = new InsumosRepository(connectionString);

            // Configura el evento Load para cargar los datos al iniciar el formulario
            this.Load += new EventHandler(InsumosForm_Load);

            // Hacer que txtVrTotal sea solo de lectura
            txtVrTotal.ReadOnly = true;

            // Asociar eventos para recalcular VrTotal cuando los valores cambien
            txtCantidad.TextChanged += (s, e) => CalcularVrTotal();
            txtVrUnitario.TextChanged += (s, e) => CalcularVrTotal();
        }

        // Método que se ejecuta cuando el formulario se carga
        private void InsumosForm_Load(object sender, EventArgs e)
        {
            LoadInsumosData(); // Carga los datos de los insumos cuando el formulario se abre
        }

        private void LoadInsumosData()
        {
            dataGridView1.DataSource = _insumosRepository.ObtenerTodosLosInsumos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                string detalle = txtDetalle.Text;
                decimal vrUnitario = decimal.Parse(txtVrUnitario.Text);

                // Fecha de entrada obtenida del DateTimePicker (debes agregar este control en tu formulario)
                DateTime fechaEntrada = dateTimePickerFechaEntrada.Value;

                // Insertar en la base de datos con todos los parámetros requeridos
                _insumosRepository.InsertarInsumo(pollosId, insumosId, cantidad, detalle, vrUnitario, fechaEntrada);
                LoadInsumosData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el insumo: {ex.Message}");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId > 0)
                {
                    int cantidad = int.Parse(txtCantidad.Text);
                    string detalle = txtDetalle.Text;
                    decimal vrUnitario = decimal.Parse(txtVrUnitario.Text);

                    // Fecha de entrada obtenida del DateTimePicker
                    DateTime fechaEntrada = dateTimePickerFechaEntrada.Value;

                    // Actualizar en la base de datos con todos los parámetros requeridos
                    _insumosRepository.ActualizarInsumo(selectedId, pollosId, insumosId, cantidad, detalle, vrUnitario, fechaEntrada);
                    LoadInsumosData();
                    ClearFields();
                    selectedId = 0;
                }
                else
                {
                    MessageBox.Show("Selecciona un insumo para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el insumo: {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                txtDetalle.Text = row.Cells["Detalle"].Value.ToString();
                txtVrUnitario.Text = row.Cells["VrUnitario"].Value.ToString();

                // Asignar la fecha de entrada al DateTimePicker
                dateTimePickerFechaEntrada.Value = Convert.ToDateTime(row.Cells["FechaEntrada"].Value);

                // Calcular y mostrar el VrTotal basado en los valores seleccionados
                CalcularVrTotal();
            }
        }

        private void CalcularVrTotal()
        {
            // Verifica si los campos tienen valores válidos antes de calcular
            if (int.TryParse(txtCantidad.Text, out int cantidad) &&
                decimal.TryParse(txtVrUnitario.Text, out decimal vrUnitario))
            {
                // Calcula VrTotal y muestra el resultado
                decimal vrTotal = cantidad * vrUnitario;
                txtVrTotal.Text = vrTotal.ToString("0.00");
            }
            else
            {
                // Si los valores no son válidos, limpia el campo VrTotal
                txtVrTotal.Text = string.Empty;
            }
        }

        private void ClearFields()
        {
            txtCantidad.Clear();
            txtDetalle.Clear();
            txtVrUnitario.Clear();
            txtVrTotal.Clear();
            dateTimePickerFechaEntrada.Value = DateTime.Now; // Resetea el DateTimePicker a la fecha actual
        }
    }
}
