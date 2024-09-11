using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PollosWeed.Repositories
{
    public class VentaPollosRepository
    {
        private readonly string _connectionString;

        public VentaPollosRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"].ConnectionString; // Reemplaza con tu cadena de conexión.
        }

        // Método para obtener todas las ventas de pollos
        public DataTable ObtenerVentas()
        {
            DataTable ventasTable = new DataTable();

            string query = "SELECT Id, Cantidad, Detalle, PesoUnitario, PesoTotal, VrUnitario, VrTotal FROM [PollosWeed].[dbo].[VentaPollos]";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            ventasTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        Console.WriteLine("Error al obtener las ventas: " + ex.Message);
                    }
                }
            }

            return ventasTable;
        }
    }
}
