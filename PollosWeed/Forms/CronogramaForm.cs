using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PollosWeed.Forms
{
    public partial class CronogramaForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"].ConnectionString;

        public CronogramaForm()
        {
            InitializeComponent();
            LoadData();
            SetTextBoxesReadOnly();
            AddLabels();
        }

        private void SetTextBoxesReadOnly()
        {
            // Hacer que los TextBox llenados por consultas no sean editables
           
            txtTipoProducto.ReadOnly = true;
            txtInsumo.ReadOnly = true;
            txtCantidad.ReadOnly = true;
          
        }

        private void AddLabels()
        {          
            // Agregar los labels al formulario
            Controls.Add(lblPollosId);
            Controls.Add(lblTipoProducto);
            Controls.Add(lblInsumosId);
            Controls.Add(lblInsumo);
            Controls.Add(lblCantidad);
           
        }

        private void btnBuscarPollo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPollosId.Text, out int pollosId))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Pollos WHERE Id = @PollosId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PollosId", pollosId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        txtPollosId.Text = row["Id"].ToString();
                        txtTipoProducto.Text = row["TipoProducto"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el ID de pollo proporcionado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de pollo válido.");
            }
        }

        private void btnBuscarInsumos_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInsumosId.Text, out int insumosId))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, Cantidad, Detalle, FechaEntrada FROM Insumos WHERE Id = @InsumosId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@InsumosId", insumosId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        txtInsumo.Text = row["Detalle"].ToString();
                        txtCantidad.Text = row["Cantidad"].ToString();
                       
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el ID de insumo proporcionado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de insumo válido.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPollosId.Text, out int pollosId) &&
                int.TryParse(txtInsumosId.Text, out int insumosId) &&
                int.TryParse(txtCantidad.Text, out int cantidad) &&
                !string.IsNullOrWhiteSpace(txtTipoProducto.Text) &&
                !string.IsNullOrWhiteSpace(txtInsumo.Text) &&
                !string.IsNullOrWhiteSpace(txtSemana.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO CronogramaInsumos (PollosId, TipoProducto, InsumosId, Insumo, Fecha, Cantidad, Semana, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo)
                VALUES (@PollosId, @TipoProducto, @InsumosId, @Insumo, @Fecha, @Cantidad, @Semana, @Lunes, @Martes, @Miercoles, @Jueves, @Viernes, @Sabado, @Domingo)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PollosId", pollosId);
                    command.Parameters.AddWithValue("@TipoProducto", txtTipoProducto.Text);
                    command.Parameters.AddWithValue("@InsumosId", insumosId);
                    command.Parameters.AddWithValue("@Insumo", txtInsumo.Text);
                    command.Parameters.AddWithValue("@Fecha", dtpFecha.Value);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Semana", txtSemana.Text);
                    command.Parameters.AddWithValue("@Lunes", string.IsNullOrWhiteSpace(txtLunes.Text) ? (object)DBNull.Value : txtLunes.Text);
                    command.Parameters.AddWithValue("@Martes", string.IsNullOrWhiteSpace(txtMartes.Text) ? (object)DBNull.Value : txtMartes.Text);
                    command.Parameters.AddWithValue("@Miercoles", string.IsNullOrWhiteSpace(txtMiercoles.Text) ? (object)DBNull.Value : txtMiercoles.Text);
                    command.Parameters.AddWithValue("@Jueves", string.IsNullOrWhiteSpace(txtJueves.Text) ? (object)DBNull.Value : txtJueves.Text);
                    command.Parameters.AddWithValue("@Viernes", string.IsNullOrWhiteSpace(txtViernes.Text) ? (object)DBNull.Value : txtViernes.Text);
                    command.Parameters.AddWithValue("@Sabado", string.IsNullOrWhiteSpace(txtSabado.Text) ? (object)DBNull.Value : txtSabado.Text);
                    command.Parameters.AddWithValue("@Domingo", string.IsNullOrWhiteSpace(txtDomingo.Text) ? (object)DBNull.Value : txtDomingo.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Datos guardados correctamente.");
                    LoadData(); // Recargar los datos en el DataGridView
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los campos obligatorios.");
            }
        }


        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CronogramaInsumos";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvCronograma.DataSource = dataTable;
            }
        }

        private void CronogramaForm_Load(object sender, EventArgs e)
        {
            // Código para inicializar el formulario cuando se carga
            LoadData();
        }
    }
}
