using System;
using System.Configuration;
using System.Windows.Forms;
using PollosWeed.Models;

namespace PollosWeed
{
    public partial class RegistrarMuerteForm : Form
    {
        private readonly PollosRepository _pollosRepository;
        private readonly MuertesPollosRepository _muertesPollosRepository;
        private Pollos _pollo;

        public RegistrarMuerteForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"].ConnectionString;
            _pollosRepository = new PollosRepository(connectionString);
            _muertesPollosRepository = new MuertesPollosRepository(connectionString);

            // Configura los campos como solo lectura
            txtCantidad.ReadOnly = true;
            txtPesoUnitario.ReadOnly = true;
            txtPrecioUnitario.ReadOnly = true;

            // Configura el DataGridView
            ConfigurarDataGridView();

            // Conectar el evento Load
            this.Load += RegistrarMuerteForm_Load;
        }


        private void RegistrarMuerteForm_Load(object sender, EventArgs e)
        {
            CargarMuertes();
        }

        private void ConfigurarDataGridView()
        {
            dataGridViewMuertes.Columns.Clear();

            dataGridViewMuertes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID" });
            dataGridViewMuertes.Columns.Add(new DataGridViewTextBoxColumn { Name = "PollosId", HeaderText = "ID del Pollo" });
            dataGridViewMuertes.Columns.Add(new DataGridViewTextBoxColumn { Name = "FechaMuerte", HeaderText = "Fecha de Muerte" });
            dataGridViewMuertes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Motivo", HeaderText = "Motivo" });
            dataGridViewMuertes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Bajas", HeaderText = "Bajas" });
        }

        private void CargarMuertes()
        {
            try
            {
                var muertes = _muertesPollosRepository.ObtenerTodasLasMuertes();
                dataGridViewMuertes.Rows.Clear();

                foreach (var muerte in muertes)
                {
                    dataGridViewMuertes.Rows.Add(muerte.Id, muerte.PollosId, muerte.FechaMuerte.ToShortDateString(), muerte.Motivo, muerte.Bajas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las muertes: " + ex.Message);
            }
        }

        // Maneja el botón "Buscar"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtId.Text, out id))
            {
                _pollo = _pollosRepository.ObtenerPolloPorId(id);
                if (_pollo != null)
                {
                    txtTipoProducto.Text = _pollo.TipoProducto;
                    txtCantidad.Text = _pollo.Cantidad.ToString(); // Convertir a string
                    txtPesoUnitario.Text = _pollo.PesoUnitario.ToString(); // Convertir a string
                    txtPrecioUnitario.Text = _pollo.PrecioUnitario.ToString(); // Convertir a string
                    dateTimePickerFechaInicio.Value = _pollo.FechaInicio;
                    
                }
                else
                {
                    MessageBox.Show("Pollo no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID inválido.");
            }
        }

        // Maneja el botón "Registrar Muerte"
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_pollo != null)
            {
                DateTime fechaMuerte = dateTimePickerFechaMuerte.Value;
                string motivo = txtMotivo.Text;
                int bajas = (int)numBajas.Value;

                try
                {
                    // Llamar al método RegistrarMuerte en el repositorio
                    _pollosRepository.RegistrarMuerte(_pollo, fechaMuerte, motivo, bajas);

                    MessageBox.Show("Muerte registrada con éxito.");
                    LimpiarCampos();
                    CargarMuertes(); // Actualiza el DataGridView después de registrar la muerte
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la muerte: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Primero busque un pollo.");
            }
        }

        // Limpia los campos del formulario
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtTipoProducto.Clear();
            txtCantidad.Clear(); // Cambiado a Clear()
            txtPesoUnitario.Clear(); // Cambiado a Clear()
            txtPrecioUnitario.Clear(); // Cambiado a Clear()
            dateTimePickerFechaInicio.Value = DateTime.Today;
            
            dateTimePickerFechaMuerte.Value = DateTime.Today;
            txtMotivo.Clear();
            numBajas.Value = 0;
            _pollo = null;
        }

        // Maneja el botón "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
