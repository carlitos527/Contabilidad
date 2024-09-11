using System;
using System.Data;
using System.Data.SqlClient;

namespace PollosWeed.Repositories
{
    public class InsumosRepository
    {
        private readonly string _connectionString;

        public InsumosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Método para obtener todos los insumos
        public DataTable ObtenerTodosLosInsumos()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [Id], [Cantidad], [Detalle], [VrUnitario], [VrTotal] FROM [PollosWeed].[dbo].[Insumos]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Método para insertar un nuevo insumo
        public void InsertarInsumo(int cantidad, string detalle, decimal vrUnitario)
        {
            // Calcular VrTotal basado en Cantidad y VrUnitario
            decimal vrTotal = cantidad * vrUnitario;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO [PollosWeed].[dbo].[Insumos] (Cantidad, Detalle, VrUnitario, VrTotal) VALUES (@Cantidad, @Detalle, @VrUnitario, @VrTotal)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Detalle", detalle);
                    command.Parameters.AddWithValue("@VrUnitario", vrUnitario);
                    command.Parameters.AddWithValue("@VrTotal", vrTotal);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar un insumo existente
        public void ActualizarInsumo(int id, int cantidad, string detalle, decimal vrUnitario)
        {
            // Calcular VrTotal basado en Cantidad y VrUnitario
            decimal vrTotal = cantidad * vrUnitario;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE [PollosWeed].[dbo].[Insumos] SET Cantidad = @Cantidad, Detalle = @Detalle, VrUnitario = @VrUnitario, VrTotal = @VrTotal WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Detalle", detalle);
                    command.Parameters.AddWithValue("@VrUnitario", vrUnitario);
                    command.Parameters.AddWithValue("@VrTotal", vrTotal);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
