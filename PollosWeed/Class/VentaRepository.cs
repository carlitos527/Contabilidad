using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PollosWeed.Models;

namespace PollosWeed.Class
{
    public class VentaRepository
    {
        private readonly string _connectionString;

        public VentaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Obtener todas las ventas
        public List<Venta> ObtenerTodasLasVentas()
        {
            var lista = new List<Venta>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [Id], [WeedId], [FechaVenta], [CantidadVendida], [PrecioTotal] FROM [PollosWeed].[dbo].[Ventas]";
                var command = new SqlCommand(query, connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Venta(
                            (int)reader["Id"],
                            (int)reader["WeedId"],
                            (int)reader["CantidadVendida"],
                            (DateTime)reader["FechaVenta"],
                            (int)reader["PrecioTotal"]
                        ));
                    }
                }
            }

            return lista;
        }
    }
}
