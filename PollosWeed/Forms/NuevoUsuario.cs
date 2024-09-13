using System;
using System.Configuration;
using System.Windows.Forms;
using PollosWeed.Class;
using PollosWeed.Models;

namespace PollosWeed.Forms
{
    public partial class AggUsuario : Form
    {
        private readonly UsuarioRepository _usuarioRepository;

        public AggUsuario()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"].ConnectionString;
            _usuarioRepository = new UsuarioRepository(connectionString);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                var usuario = new Usuario
                {
                    NombreUsuario = nombreUsuario,
                    Password = password // Asegúrate de que el PasswordHelper hash la contraseña
                };

                _usuarioRepository.AgregarUsuario(usuario);

                MessageBox.Show("Usuario registrado exitosamente.");

                txtNombreUsuario.Clear();
                txtPassword.Clear();

                // Mostrar la instancia global del formulario Bienvenido y cerrar el formulario actual
                ShowBienvenidoForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}");
            }
        }

        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;

                
            }
        }

        private void SetPlaceholderText(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = System.Drawing.Color.Gray;

                if (textBox == txtNombreUsuario)
                {
                    textBox.Text = "Ingrese nombre de usuario";
                }
                else if (textBox == txtPassword)
                {
                    textBox.Text = "Ingrese la contraseña";
                    textBox.UseSystemPasswordChar = false;
                }
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ShowBienvenidoForm();
        }

        private void ShowBienvenidoForm()
        {
            // Muestra la instancia global del formulario Bienvenido y cierra el formulario actual
            Bienvenido.Instance.Show();
            this.Close();
        }
    }
}
