using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using PollosWeed.Models;

namespace PollosWeed.Class
{
    public class WeedRepository
    {
        private readonly string _connectionString;

        public WeedRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Obtener todos los productos
        public List<Weed> ObtenerTodos()
        {
            var lista = new List<Weed>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT [Id], [Producto], [Cantidad], [Peso], [Precio], [CantidadRestante], [FechaInicio], [FechaUltimaVenta] FROM [PollosWeed].[dbo].[Weed]";
                var command = new SqlCommand(query, connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Weed(
                            (int)reader["Id"],
                            reader["Producto"].ToString(),
                            (int)reader["Cantidad"],
                            (int)reader["Peso"],
                            (int)reader["Precio"],
                            (DateTime)reader["FechaInicio"]
                        )
                        {
                            CantidadRestante = (int)reader["CantidadRestante"],
                            FechaUltimaVenta = reader["FechaUltimaVenta"] as DateTime?
                        });
                    }
                }
            }

            return lista;
        }

        // Agregar un nuevo producto
        public void Agregar(Weed weed)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO [PollosWeed].[dbo].[Weed] ([Producto], [Cantidad], [Peso], [Precio], [CantidadRestante], [FechaInicio]) " +
                               "VALUES (@Producto, @Cantidad, @Peso, @Precio, @CantidadRestante, @FechaInicio)";
                var command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Producto", weed.Producto);
                command.Parameters.AddWithValue("@Cantidad", weed.Cantidad);
                command.Parameters.AddWithValue("@Peso", weed.Peso);
                command.Parameters.AddWithValue("@Precio", weed.Precio);
                command.Parameters.AddWithValue("@CantidadRestante", weed.CantidadRestante);
                command.Parameters.AddWithValue("@FechaInicio", weed.FechaInicio);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Registrar una venta
        public void RegistrarVenta(int id, int cantidadVendida, DateTime fechaVenta)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Calcular el precio total multiplicado por 10,000
                        int precioTotal = cantidadVendida * 10000;

                        // Actualizar la cantidad restante del producto
                        string updateQuery = "UPDATE [PollosWeed].[dbo].[Weed] SET [CantidadRestante] = [CantidadRestante] - @CantidadVendida, [FechaUltimaVenta] = @FechaVenta " +
                                             "WHERE [Id] = @Id";
                        var updateCommand = new SqlCommand(updateQuery, connection, transaction);
                        updateCommand.Parameters.AddWithValue("@CantidadVendida", cantidadVendida);
                        updateCommand.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                        updateCommand.Parameters.AddWithValue("@Id", id);
                        updateCommand.ExecuteNonQuery();

                        // Insertar el registro de la venta
                        string insertQuery = "INSERT INTO [PollosWeed].[dbo].[Ventas] ([WeedId], [FechaVenta], [CantidadVendida], [PrecioTotal]) " +
                                             "VALUES (@Id, @FechaVenta, @CantidadVendida, @PrecioTotal)";
                        var insertCommand = new SqlCommand(insertQuery, connection, transaction);
                        insertCommand.Parameters.AddWithValue("@Id", id);
                        insertCommand.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                        insertCommand.Parameters.AddWithValue("@CantidadVendida", cantidadVendida);
                        insertCommand.Parameters.AddWithValue("@PrecioTotal", precioTotal);
                        insertCommand.ExecuteNonQuery();

                        // Confirmar la transacción
                        transaction.Commit();
                        MessageBox.Show("Venta registrada con éxito.");
                    }
                    catch (Exception ex)
                    {
                        // Deshacer la transacción en caso de error
                        transaction.Rollback();
                        MessageBox.Show("Error al registrar venta: " + ex.Message);
                    }
                }
            }
        }


     

    }
}
