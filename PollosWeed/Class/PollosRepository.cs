using System;
using System.Collections.Generic;
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
            // Truncar PrecioTotal a entero
            int precioTotalTruncado = (int)(pollo.Cantidad * pollo.PrecioUnitario);
            pollo.PrecioTotal = precioTotalTruncado;

            // Truncar PesoUnitario y PrecioUnitario a enteros
            int pesoUnitarioTruncado = (int)pollo.PesoUnitario;
            int precioUnitarioTruncado = (int)pollo.PrecioUnitario;

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO [Pollos] (TipoProducto, Cantidad, PesoUnitario, PrecioUnitario, FechaInicio, FechaFin, PrecioTotal) " +
                               "VALUES (@TipoProducto, @Cantidad, @PesoUnitario, @PrecioUnitario, @FechaInicio, @FechaFin, @PrecioTotal)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TipoProducto", pollo.TipoProducto);
                    command.Parameters.AddWithValue("@Cantidad", pollo.Cantidad);
                    command.Parameters.AddWithValue("@PesoUnitario", pesoUnitarioTruncado);
                    command.Parameters.AddWithValue("@PrecioUnitario", precioUnitarioTruncado);
                    command.Parameters.AddWithValue("@FechaInicio", pollo.FechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", (object)pollo.FechaFin ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PrecioTotal", precioTotalTruncado);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }




        public List<Pollos> ObtenerTodosLosPollos()
        {
            var listaPollos = new List<Pollos>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [Id], [TipoProducto], [Cantidad], [PesoUnitario], [PrecioUnitario], [FechaInicio], [FechaFin], [PrecioTotal] FROM [Pollos]";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pollo = new Pollos
                            {
                                Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0,
                                TipoProducto = reader["TipoProducto"] != DBNull.Value ? reader["TipoProducto"].ToString() : string.Empty,
                                Cantidad = reader["Cantidad"] != DBNull.Value ? Convert.ToInt32(reader["Cantidad"]) : 0,
                                PesoUnitario = reader["PesoUnitario"] != DBNull.Value ? Convert.ToInt32(reader["PesoUnitario"]) : 0, // Cambiado a Convert.ToInt32
                                PrecioUnitario = reader["PrecioUnitario"] != DBNull.Value ? Convert.ToInt32(reader["PrecioUnitario"]) : 0, // Cambiado a Convert.ToInt32
                                FechaInicio = reader["FechaInicio"] != DBNull.Value ? Convert.ToDateTime(reader["FechaInicio"]) : DateTime.MinValue,
                                FechaFin = reader["FechaFin"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["FechaFin"]) : null,
                                PrecioTotal = reader["PrecioTotal"] != DBNull.Value ? Convert.ToInt32(reader["PrecioTotal"]) : 0 // Cambiado a Convert.ToInt32
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE Pollos SET FechaFin = @FechaFin WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
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
                        TipoProducto = (string)reader["TipoProducto"],
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

                // Insertar la muerte en la tabla MuertesPollos
                var command = new SqlCommand("INSERT INTO MuertesPollos (PollosId, FechaMuerte, Motivo, Bajas) VALUES (@PollosId, @FechaMuerte, @Motivo, @Bajas)", connection);
                command.Parameters.AddWithValue("@PollosId", pollo.Id);
                command.Parameters.AddWithValue("@FechaMuerte", fechaMuerte);
                command.Parameters.AddWithValue("@Motivo", motivo);
                command.Parameters.AddWithValue("@Bajas", bajas);
                command.ExecuteNonQuery();

                // Actualizar la cantidad de pollos en la tabla Pollos
                pollo.Cantidad -= bajas; // Restar las bajas de la cantidad
                command = new SqlCommand("UPDATE Pollos SET Cantidad = @Cantidad WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Cantidad", pollo.Cantidad);
                command.Parameters.AddWithValue("@Id", pollo.Id);
                command.ExecuteNonQuery();
            }
        }



    }
}
