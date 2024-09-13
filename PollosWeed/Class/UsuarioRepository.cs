using PollosWeed.Models;
using System;
using System.Data.SqlClient;

namespace PollosWeed.Class
{
    public class UsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            // Aquí deberías hash la contraseña, asegurándote de que se almacene de manera segura
            string hashedPassword = PasswordHelper.HashPassword(usuario.Password);

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO [PollosWeed].[dbo].[Usuarios] (NombreUsuario, Password) VALUES (@NombreUsuario, @Password)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT Id, NombreUsuario, Password FROM [PollosWeed].[dbo].[Usuarios] WHERE NombreUsuario = @NombreUsuario";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2));
                        }
                    }
                }
            }
            return null;
        }

        public Usuario ObtenerUsuario(string nombreUsuario, string password)
        {
            string hashedPassword = PasswordHelper.HashPassword(password);

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Password = @Password", connection);
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@Password", hashedPassword); // Asegúrate de que la contraseña esté hasheada en la base de datos

                connection.Open();
                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Usuario
                    {
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        Password = reader["Password"].ToString()
                    };
                }

                return null;
            }
        }

        public bool ExistePerfil()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM [PollosWeed].[dbo].[Usuarios]";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
