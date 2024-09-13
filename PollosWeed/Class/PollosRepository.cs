using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PollosWeed.Models;

namespace PollosWeed
{
    public class PollosRepository
    {
        private readonly string _connectionString;

        public PollosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertarPollo(Pollos pollo)
        {
            // Truncar PrecioTotal, PesoUnitario y PrecioUnitario a enteros
            int precioTotalTruncado = (int)(pollo.Cantidad * pollo.PrecioUnitario);
            pollo.PrecioTotal = precioTotalTruncado;

            int pesoUnitarioTruncado = (int)pollo.PesoUnitario;
            int precioUnitarioTruncado = (int)pollo.PrecioUnitario;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Iniciar una transacción
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insertar en la tabla Pollos
                        string queryInsert = "INSERT INTO [Pollos] (TipoProducto, Cantidad, PesoUnitario, PrecioUnitario, FechaInicio, FechaFin, PrecioTotal) " +
                                             "VALUES (@TipoProducto, @Cantidad, @PesoUnitario, @PrecioUnitario, @FechaInicio, @FechaFin, @PrecioTotal); " +
                                             "SELECT SCOPE_IDENTITY();";

                        int polloId;
                        using (var commandInsert = new SqlCommand(queryInsert, connection, transaction))
                        {
                            commandInsert.Parameters.AddWithValue("@TipoProducto", pollo.TipoProducto ?? (object)DBNull.Value);
                            commandInsert.Parameters.AddWithValue("@Cantidad", pollo.Cantidad);
                            commandInsert.Parameters.AddWithValue("@PesoUnitario", pesoUnitarioTruncado);
                            commandInsert.Parameters.AddWithValue("@PrecioUnitario", precioUnitarioTruncado);
                            commandInsert.Parameters.AddWithValue("@FechaInicio", pollo.FechaInicio);
                            commandInsert.Parameters.AddWithValue("@FechaFin", (object)pollo.FechaFin ?? DBNull.Value);
                            commandInsert.Parameters.AddWithValue("@PrecioTotal", precioTotalTruncado);

                            var result = commandInsert.ExecuteScalar();

                            // Verificar si el resultado es DBNull antes de convertirlo
                            if (result != DBNull.Value)
                            {
                                polloId = Convert.ToInt32(result);
                                Console.WriteLine("ID del pollo insertado: " + polloId); // Mensaje de depuración
                            }
                            else
                            {
                                throw new InvalidOperationException("No se pudo obtener el Id del pollo recién insertado.");
                            }
                        }

                        // Llamar al procedimiento almacenado para actualizar CronogramaInsumos
                        string queryUpdate = "EXEC sp_ActualizarCronogramaInsumos @PollosId, @InsumosId, @TipoProducto, @Insumo, @Fecha, @Cantidad";

                        using (var commandUpdate = new SqlCommand(queryUpdate, connection, transaction))
                        {
                            commandUpdate.Parameters.AddWithValue("@PollosId", polloId);
                            commandUpdate.Parameters.AddWithValue("@InsumosId", DBNull.Value); // Ajustar según el uso de InsumosId
                            commandUpdate.Parameters.AddWithValue("@TipoProducto", DBNull.Value); // Ajustar según el uso de TipoProducto
                            commandUpdate.Parameters.AddWithValue("@Insumo", DBNull.Value); // Ajustar según el uso de Insumo
                            commandUpdate.Parameters.AddWithValue("@Fecha", DBNull.Value); // Ajustar según el uso de Fecha
                            commandUpdate.Parameters.AddWithValue("@Cantidad", DBNull.Value); // Ajustar según el uso de Cantidad

                            commandUpdate.ExecuteNonQuery();
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                    }
                    catch
                    {
                        // Revertir la transacción en caso de error
                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                        {
                            transaction.Rollback();
                        }
                        throw;
                    }
                }
            }
        }

        public List<Pollos> ObtenerTodosLosPollos()
        {
            var listaPollos = new List<Pollos>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT [Id], [TipoProducto], [Cantidad], [PesoUnitario], [PrecioUnitario], [FechaInicio], [FechaFin], [PrecioTotal] FROM [Pollos]";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pollo = new Pollos
                            {
                                Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0,
                                TipoProducto = reader["TipoProducto"] != DBNull.Value ? reader["TipoProducto"].ToString() : string.Empty,
                                Cantidad = reader["Cantidad"] != DBNull.Value ? Convert.ToInt32(reader["Cantidad"]) : 0,
                                PesoUnitario = reader["PesoUnitario"] != DBNull.Value ? Convert.ToInt32(reader["PesoUnitario"]) : 0,
                                PrecioUnitario = reader["PrecioUnitario"] != DBNull.Value ? Convert.ToInt32(reader["PrecioUnitario"]) : 0,
                                FechaInicio = reader["FechaInicio"] != DBNull.Value ? Convert.ToDateTime(reader["FechaInicio"]) : DateTime.MinValue,
                                FechaFin = reader["FechaFin"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["FechaFin"]) : null,
                                PrecioTotal = reader["PrecioTotal"] != DBNull.Value ? Convert.ToInt32(reader["PrecioTotal"]) : 0
                            };

                            listaPollos.Add(pollo);
                        }
                    }
                }
            }

            return listaPollos;
        }

        public void ActualizarFechaFin(int id, DateTime fechaFin)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Pollos SET FechaFin = @FechaFin WHERE Id = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FechaFin", fechaFin);
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Pollos ObtenerPolloPorId(int id)
        {
            Pollos pollo = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Pollos WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    pollo = new Pollos
                    {
                        Id = (int)reader["Id"],
                        TipoProducto = reader["TipoProducto"].ToString(),
                        Cantidad = (int)reader["Cantidad"],
                        PesoUnitario = (int)reader["PesoUnitario"],
                        PrecioUnitario = (int)reader["PrecioUnitario"],
                        FechaInicio = (DateTime)reader["FechaInicio"],
                        FechaFin = reader["FechaFin"] as DateTime?
                    };
                }
            }

            return pollo;
        }

        public void RegistrarMuerte(Pollos pollo, DateTime fechaMuerte, string motivo, int bajas)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO MuertesPollos (PolloId, FechaMuerte, Motivo, Bajas) VALUES (@PolloId, @FechaMuerte, @Motivo, @Bajas)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PolloId", pollo.Id);
                    command.Parameters.AddWithValue("@FechaMuerte", fechaMuerte);
                    command.Parameters.AddWithValue("@Motivo", motivo);
                    command.Parameters.AddWithValue("@Bajas", bajas);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
