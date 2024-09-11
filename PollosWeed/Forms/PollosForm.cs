using System;
using System.Configuration;
using System.Windows.Forms;
using PollosWeed.Forms;
using PollosWeed.Models;

namespace PollosWeed
{
    public partial class PollosForm : Form
    {
        private readonly PollosRepository _pollosRepository;

        public PollosForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"].ConnectionString;
            _pollosRepository = new PollosRepository(connectionString);
            InicializarDataGridView();
            CargarDatos();
        }

        // Configura el DataGridView
        private void InicializarDataGridView()
        {
            dataGridViewPollos.AutoGenerateColumns = false;
            dataGridViewPollos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "Id", Visible = false });
            dataGridViewPollos.Columns.Add(new DataGridViewTextBoxColumn { Name = "TipoProducto", HeaderText = "Tipo Producto", DataPropertyName = "TipoProducto" });
            dataGridViewPollos.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad", HeaderText = "Cantidad", DataPropertyName = "Cantidad" });
            dataGridViewPollos.Columns.Add(new DataGridViewTextBoxColumn { Name = "PesoUnitario", HeaderText = "Peso Unitario", DataPropertyName = "PesoUnitario", DefaultCellStyle = new DataGridViewCellStyle { Format = "0" } });
            dataGridViewPollos.Columns.Add(new DataGridViewTextBoxColumn { Name = "PrecioUnitario", HeaderText = "Precio Unitario", DataPropertyName = "PrecioUnitario", DefaultCellStyle = new DataGridViewCellStyle { Format = "0" } });
            dataGridViewPollos.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaInicio", HeaderText = "Fecha Inicio", DataPropertyName = "FechaInicio" });
            dataGridViewPollos.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaFin", HeaderText = "Fecha Fin", DataPropertyName = "FechaFin" });
            dataGridViewPollos.Columns.Add(new DataGridViewTextBoxColumn { Name = "PrecioTotal", HeaderText = "Precio Total", DataPropertyName = "PrecioTotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "0" } });
        }

        // Maneja el botón "Agregar Pollo"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoPollo = new Pollos
            {
                TipoProducto = txtTipoProducto.Text,
                Cantidad = (int)numCantidad.Value,
                PesoUnitario = (int)numPesoUnitario.Value, // Truncar a entero
                PrecioUnitario = (int)numPrecioUnitario.Value, // Truncar a entero
                FechaInicio = dateTimePickerFechaInicio.Value,
                FechaFin = null // No asignar FechaFin al agregar
            };

            _pollosRepository.InsertarPollo(nuevoPollo);
            CargarDatos();
            LimpiarCampos();
        }

        // Maneja el botón "Actualizar Fecha Fin"
        private void btnActualizarFechaFin_Click(object sender, EventArgs e)
        {
            if (dataGridViewPollos.SelectedRows.Count > 0)
            {
                // Obtener el ID del registro seleccionado
                int id = Convert.ToInt32(dataGridViewPollos.SelectedRows[0].Cells["Id"].Value);
                // Obtener la fecha seleccionada en el DateTimePicker para la FechaFin
                DateTime fechaFin = dateTimePickerFechaFin.Value;

                // Actualiza la FechaFin del registro seleccionado en la base de datos
                _pollosRepository.ActualizarFechaFin(id, fechaFin);

                MessageBox.Show("Fecha Fin actualizada con éxito.");
                // Recarga los datos para reflejar los cambios en el DataGridView
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro para actualizar.");
            }
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtTipoProducto.Clear();
            numCantidad.Value = 0;
            numPesoUnitario.Value = 0;
            numPrecioUnitario.Value = 0;
            dateTimePickerFechaInicio.Value = DateTime.Today;
            dateTimePickerFechaFin.Value = DateTime.Today;
        }

        // Carga los datos en el DataGridView
        private void CargarDatos()
        {
            var listaPollos = _pollosRepository.ObtenerTodosLosPollos();
            dataGridViewPollos.DataSource = listaPollos;

            // Configura el formato de las columnas para mostrar enteros sin decimales
            dataGridViewPollos.Columns["PesoUnitario"].DefaultCellStyle.Format = "0";
            dataGridViewPollos.Columns["PrecioUnitario"].DefaultCellStyle.Format = "0";
            dataGridViewPollos.Columns["PrecioTotal"].DefaultCellStyle.Format = "0";
        }

        private void PollosForm_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar datos o cargar configuraciones necesarias
            // Ejemplo: Cargar datos desde la base de datos al DataGridView
            //CargarDatosIniciales();
        }

        private void Kill_Click(object sender, EventArgs e)
        {
            using (RegistrarMuerteForm registrarMuerteForm = new RegistrarMuerteForm())
            {
                // Muestra el nuevo formulario como un cuadro de diálogo modal
                registrarMuerteForm.ShowDialog();
            }

        }

        private void VentasPollo_Click(object sender, EventArgs e)
        {
            using (RegistrarVentaForm registrarVentaForm = new RegistrarVentaForm())
            {
                // Muestra el nuevo formulario como un cuadro de diálogo modal
                registrarVentaForm.ShowDialog();
            }

        }
    }
}
