using PollosWeed.Repositories;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PollosWeed.Forms
{
    public partial class RegistrarVentaForm : Form
    {
        private readonly VentaPollosRepository _ventaPollosRepository;

        public RegistrarVentaForm()
        {
            InitializeComponent();
            _ventaPollosRepository = new VentaPollosRepository();
        }

        private void RegistrarVentaForm_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // Validar entradas
            if (!int.TryParse(txtCantidad.Text, out int cantidad) ||
                !int.TryParse(txtPesoUnitario.Text, out int pesoUnitario) ||
                !int.TryParse(txtVrUnitario.Text, out int vrUnitario))
            {
                MessageBox.Show("Por favor, ingresa valores enteros en los campos numéricos.");
                return;
            }

            // Calcular valores
            int pesoTotal = cantidad * pesoUnitario;
            int vrTotal = cantidad * vrUnitario;

            // Mostrar valores calculados
            txtPesoTotal.Text = pesoTotal.ToString();
            txtVrTotal.Text = vrTotal.ToString();

            // Conexión a la base de datos
            string connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"].ConnectionString;
            string query = "INSERT INTO [PollosWeed].[dbo].[VentaPollos] (Cantidad, Detalle, PesoUnitario, PesoTotal, VrUnitario, VrTotal) " +
                           "VALUES (@Cantidad, @Detalle, @PesoUnitario, @PesoTotal, @VrUnitario, @VrTotal)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Detalle", txtDetalle.Text);
                    command.Parameters.AddWithValue("@PesoUnitario", pesoUnitario);
                    command.Parameters.AddWithValue("@PesoTotal", pesoTotal);
                    command.Parameters.AddWithValue("@VrUnitario", vrUnitario);
                    command.Parameters.AddWithValue("@VrTotal", vrTotal);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Venta registrada exitosamente.");
                        LimpiarCampos(); // Limpiar los campos después de registrar la venta.
                        CargarVentas(); // Actualizar el DataGridView después de registrar una venta.
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar la venta: " + ex.Message);
                    }
                }
            }
        }

        private void CargarVentas()
        {
            try
            {
                DataTable ventas = _ventaPollosRepository.ObtenerVentas();
                dgvVentas.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtCantidad.Clear();
            txtDetalle.Clear();
            txtPesoUnitario.Clear();
            txtPesoTotal.Clear();
            txtVrUnitario.Clear();
            txtVrTotal.Clear();
        }
    }
}
