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
                string query = "SELECT [Id], [Cantidad], [Detalle], [VrUnitario], [VrTotal], [FechaEntrada] FROM [PollosWeed].[dbo].[Insumos]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Método para insertar un nuevo insumo con FechaEntrada y actualizar el Cronograma de Insumos
        public void InsertarInsumo(int pollosId, int insumosId, int cantidad, string detalle, decimal vrUnitario, DateTime fechaEntrada)
        {
            // Calcular VrTotal basado en Cantidad y VrUnitario
            decimal vrTotal = cantidad * vrUnitario;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Insertar en la tabla Insumos
                string queryInsert = "INSERT INTO [PollosWeed].[dbo].[Insumos] (Cantidad, Detalle, VrUnitario, VrTotal, FechaEntrada) " +
                                     "VALUES (@Cantidad, @Detalle, @VrUnitario, @VrTotal, @FechaEntrada)";

                using (SqlCommand command = new SqlCommand(queryInsert, connection))
                {
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Detalle", detalle);
                    command.Parameters.AddWithValue("@VrUnitario", vrUnitario);
                    command.Parameters.AddWithValue("@VrTotal", vrTotal);
                    command.Parameters.AddWithValue("@FechaEntrada", fechaEntrada); // Asegúrate de que esto sea un DateTime

                    command.ExecuteNonQuery();
                }

               
            }
        }


        // Método para actualizar un insumo existente y el Cronograma de Insumos
        public void ActualizarInsumo(int id, int pollosId, int insumosId, int cantidad, string detalle, decimal vrUnitario, DateTime fechaEntrada)
        {
            // Calcular VrTotal basado en Cantidad y VrUnitario
            decimal vrTotal = cantidad * vrUnitario;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Actualizar la tabla Insumos
                string queryUpdate = "UPDATE [PollosWeed].[dbo].[Insumos] " +
                                     "SET Cantidad = @Cantidad, Detalle = @Detalle, VrUnitario = @VrUnitario, VrTotal = @VrTotal, FechaEntrada = @FechaEntrada " +
                                     "WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(queryUpdate, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Cantidad", cantidad);
                    command.Parameters.AddWithValue("@Detalle", detalle);
                    command.Parameters.AddWithValue("@VrUnitario", vrUnitario);
                    command.Parameters.AddWithValue("@VrTotal", vrTotal);
                    command.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);

                    command.ExecuteNonQuery();
                }

                // Llamar al procedimiento almacenado para actualizar CronogramaInsumos
                string queryCronogramaUpdate = "EXEC [dbo].[sp_ActualizarCronogramaInsumos] @PollosId, @InsumosId, @Fecha, @Cantidad";

                using (SqlCommand commandCronograma = new SqlCommand(queryCronogramaUpdate, connection))
                {
                    commandCronograma.Parameters.AddWithValue("@PollosId", pollosId);
                    commandCronograma.Parameters.AddWithValue("@InsumosId", insumosId);
                    commandCronograma.Parameters.AddWithValue("@Fecha", fechaEntrada);
                    commandCronograma.Parameters.AddWithValue("@Cantidad", cantidad);

                    commandCronograma.ExecuteNonQuery();
                }
            }
        }
    }
}
