using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PollosWeed.Models;

namespace PollosWeed
{
    public class MuertesPollosRepository
    {
        private readonly string _connectionString;

        public MuertesPollosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<MuertePollos> ObtenerTodasLasMuertes()
        {
            var listaMuertes = new List<MuertePollos>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [Id], [PollosId], [FechaMuerte], [Motivo], [Bajas] FROM [PollosWeed].[dbo].[MuertesPollos]";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var muerte = new MuertePollos
                            {
                                Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0,
                                PollosId = reader["PollosId"] != DBNull.Value ? Convert.ToInt32(reader["PollosId"]) : 0,
                                FechaMuerte = reader["FechaMuerte"] != DBNull.Value ? Convert.ToDateTime(reader["FechaMuerte"]) : DateTime.MinValue,
                                Motivo = reader["Motivo"] != DBNull.Value ? reader["Motivo"].ToString() : string.Empty,
                                Bajas = reader["Bajas"] != DBNull.Value ? Convert.ToInt32(reader["Bajas"]) : 0
                            };

                            listaMuertes.Add(muerte);
                        }
                    }
                }
            }

            return listaMuertes;
        }
    }
}
