using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PollosWeed.Models;

namespace PollosWeed.Controllers
{
    public class CronogramaController
    {
        private readonly string _connectionString;

        public CronogramaController(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Obtener todos los registros
        public List<Cronograma> ObtenerTodosLosCronogramas()
        {
            var cronogramas = new List<Cronograma>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT TOP (1000) [Id], [PollosId], [TipoProducto], [InsumosId], [Insumo], [Fecha], [Cantidad], [Semana], [Lunes], [Martes], [Miercoles], [Jueves], [Viernes], [Sabado], [Domingo] FROM [PollosWeed].[dbo].[CronogramaInsumos]";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cronograma = new Cronograma
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                PollosId = reader.GetInt32(reader.GetOrdinal("PollosId")),
                                TipoProducto = reader.GetString(reader.GetOrdinal("TipoProducto")),
                                InsumosId = reader.GetInt32(reader.GetOrdinal("InsumosId")),
                                Insumo = reader.GetString(reader.GetOrdinal("Insumo")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                                Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                                Semana = reader.IsDBNull(reader.GetOrdinal("Semana")) ? null : reader.GetString(reader.GetOrdinal("Semana")),
                                Lunes = reader.IsDBNull(reader.GetOrdinal("Lunes")) ? null : reader.GetString(reader.GetOrdinal("Lunes")),
                                Martes = reader.IsDBNull(reader.GetOrdinal("Martes")) ? null : reader.GetString(reader.GetOrdinal("Martes")),
                                Miercoles = reader.IsDBNull(reader.GetOrdinal("Miercoles")) ? null : reader.GetString(reader.GetOrdinal("Miercoles")),
                                Jueves = reader.IsDBNull(reader.GetOrdinal("Jueves")) ? null : reader.GetString(reader.GetOrdinal("Jueves")),
                                Viernes = reader.IsDBNull(reader.GetOrdinal("Viernes")) ? null : reader.GetString(reader.GetOrdinal("Viernes")),
                                Sabado = reader.IsDBNull(reader.GetOrdinal("Sabado")) ? null : reader.GetString(reader.GetOrdinal("Sabado")),
                                Domingo = reader.IsDBNull(reader.GetOrdinal("Domingo")) ? null : reader.GetString(reader.GetOrdinal("Domingo"))
                            };

                            cronogramas.Add(cronograma);
                        }
                    }
                }
            }

            return cronogramas;
        }

        // Obtener un registro por Id
        public Cronograma ObtenerCronogramaPorId(int id)
        {
            Cronograma cronograma = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [Id], [PollosId], [TipoProducto], [InsumosId], [Insumo], [Fecha], [Cantidad], [Semana], [Lunes], [Martes], [Miercoles], [Jueves], [Viernes], [Sabado], [Domingo] FROM [PollosWeed].[dbo].[CronogramaInsumos] WHERE [Id] = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cronograma = new Cronograma
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                PollosId = reader.GetInt32(reader.GetOrdinal("PollosId")),
                                TipoProducto = reader.GetString(reader.GetOrdinal("TipoProducto")),
                                InsumosId = reader.GetInt32(reader.GetOrdinal("InsumosId")),
                                Insumo = reader.GetString(reader.GetOrdinal("Insumo")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                                Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                                Semana = reader.IsDBNull(reader.GetOrdinal("Semana")) ? null : reader.GetString(reader.GetOrdinal("Semana")),
                                Lunes = reader.IsDBNull(reader.GetOrdinal("Lunes")) ? null : reader.GetString(reader.GetOrdinal("Lunes")),
                                Martes = reader.IsDBNull(reader.GetOrdinal("Martes")) ? null : reader.GetString(reader.GetOrdinal("Martes")),
                                Miercoles = reader.IsDBNull(reader.GetOrdinal("Miercoles")) ? null : reader.GetString(reader.GetOrdinal("Miercoles")),
                                Jueves = reader.IsDBNull(reader.GetOrdinal("Jueves")) ? null : reader.GetString(reader.GetOrdinal("Jueves")),
                                Viernes = reader.IsDBNull(reader.GetOrdinal("Viernes")) ? null : reader.GetString(reader.GetOrdinal("Viernes")),
                                Sabado = reader.IsDBNull(reader.GetOrdinal("Sabado")) ? null : reader.GetString(reader.GetOrdinal("Sabado")),
                                Domingo = reader.IsDBNull(reader.GetOrdinal("Domingo")) ? null : reader.GetString(reader.GetOrdinal("Domingo"))
                            };
                        }
                    }
                }
            }

            return cronograma;
        }

        // Consultar tabla Pollos
        public List<Pollos> ObtenerTodosLosPollos()
        {
            var pollos = new List<Pollos>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [Id], [TipoProducto], [Cantidad], [PesoUnitario], [PesoTotal], [PrecioUnitario], [PrecioTotal], [FechaInicio], [FechaFin] FROM [PollosWeed].[dbo].[Pollos]";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pollo = new Pollos
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                TipoProducto = reader.GetString(reader.GetOrdinal("TipoProducto")),
                                Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                               
                            };

                            pollos.Add(pollo);
                        }
                    }
                }
            }

            return pollos;
        }

        // Consultar tabla Insumos
        public List<Insumos> ObtenerTodosLosInsumos()
        {
            var insumos = new List<Insumos>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [Id], [Detalle], [Cantidad], [FechaIngreso] FROM [PollosWeed].[dbo].[Insumos]";

                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var insumo = new Insumos
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Detalle = reader.GetString(reader.GetOrdinal("Detalle")),
                                Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                                FechaEntrada = reader.GetDateTime(reader.GetOrdinal("FechaIngreso"))
                            };

                            insumos.Add(insumo);
                        }
                    }
                }
            }

            return insumos;
        }

        // Insertar nuevo registro en Cronograma
        public void InsertarCronograma(Cronograma cronograma)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO [PollosWeed].[dbo].[CronogramaInsumos] " +
                               "([PollosId], [TipoProducto], [InsumosId], [Insumo], [Fecha], [Cantidad], [Semana], [Lunes], [Martes], [Miercoles], [Jueves], [Viernes], [Sabado], [Domingo]) " +
                               "VALUES (@PollosId, @TipoProducto, @InsumosId, @Insumo, @Fecha, @Cantidad, @Semana, @Lunes, @Martes, @Miercoles, @Jueves, @Viernes, @Sabado, @Domingo)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PollosId", cronograma.PollosId);
                    command.Parameters.AddWithValue("@TipoProducto", cronograma.TipoProducto);
                    command.Parameters.AddWithValue("@InsumosId", cronograma.InsumosId);
                    command.Parameters.AddWithValue("@Insumo", cronograma.Insumo);
                    command.Parameters.AddWithValue("@Fecha", cronograma.Fecha);
                    command.Parameters.AddWithValue("@Cantidad", cronograma.Cantidad);

                    // Asegúrate de que la semana no sea nula
                    command.Parameters.AddWithValue("@Semana", string.IsNullOrEmpty(cronograma.Semana) ? DBNull.Value : (object)cronograma.Semana);

                    // Los días de la semana pueden ser nulos
                    command.Parameters.AddWithValue("@Lunes", string.IsNullOrEmpty(cronograma.Lunes) ? DBNull.Value : (object)cronograma.Lunes);
                    command.Parameters.AddWithValue("@Martes", string.IsNullOrEmpty(cronograma.Martes) ? DBNull.Value : (object)cronograma.Martes);
                    command.Parameters.AddWithValue("@Miercoles", string.IsNullOrEmpty(cronograma.Miercoles) ? DBNull.Value : (object)cronograma.Miercoles);
                    command.Parameters.AddWithValue("@Jueves", string.IsNullOrEmpty(cronograma.Jueves) ? DBNull.Value : (object)cronograma.Jueves);
                    command.Parameters.AddWithValue("@Viernes", string.IsNullOrEmpty(cronograma.Viernes) ? DBNull.Value : (object)cronograma.Viernes);
                    command.Parameters.AddWithValue("@Sabado", string.IsNullOrEmpty(cronograma.Sabado) ? DBNull.Value : (object)cronograma.Sabado);
                    command.Parameters.AddWithValue("@Domingo", string.IsNullOrEmpty(cronograma.Domingo) ? DBNull.Value : (object)cronograma.Domingo);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
