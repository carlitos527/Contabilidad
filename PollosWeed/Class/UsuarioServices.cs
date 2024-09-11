using PollosWeed.Models;
using System;

namespace PollosWeed.Class
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService(string connectionString)
        {
            _usuarioRepository = new UsuarioRepository(connectionString);
        }

        public void AgregarUsuario(string nombreUsuario, string password)
        {
            // Validar el nombre de usuario y la contraseña
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("La contraseña no puede estar vacía.");

            // Crear una instancia del usuario
            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                Password = password // Recuerda, debes almacenar un hash de la contraseña
            };

            // Llamar al repositorio para agregar el usuario
            _usuarioRepository.AgregarUsuario(nuevoUsuario);
        }
    }
}
