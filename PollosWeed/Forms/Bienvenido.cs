using System;
using System.Configuration;
using System.Windows.Forms;
using PollosWeed.Class;

namespace PollosWeed.Forms
{
    public partial class Bienvenido : Form
    {
        private static Bienvenido _instance;
        private readonly UsuarioRepository _usuarioRepository;

        public Bienvenido()
        {
            InitializeComponent();

            // Obtener la cadena de conexión desde el archivo de configuración
            var connectionStringSetting = ConfigurationManager.ConnectionStrings["PollosWeedConnection"];
            if (connectionStringSetting == null)
            {
                MessageBox.Show("Cadena de conexión no encontrada en el archivo de configuración.");
                return;
            }

            string connectionString = connectionStringSetting.ConnectionString;

            // Inicializa el repositorio pasando la cadena de conexión
            _usuarioRepository = new UsuarioRepository(connectionString);

            VerificarPerfiles(); // Llama a la función para verificar perfiles.
        }

        public static Bienvenido Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Bienvenido();
                }
                return _instance;
            }
        }

        private void VerificarPerfiles()
        {
            try
            {
                if (_usuarioRepository.ExistePerfil())
                {
                    btnCrear.Enabled = false; // Deshabilitar el botón de crear perfil
                   // MessageBox.Show("Ya existe un perfil creado. No puedes crear más perfiles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar perfiles: {ex.Message}");
            }
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            AggUsuario aggUsuarioForm = new AggUsuario();
            aggUsuarioForm.Show();
            this.Hide(); // Oculta el formulario Bienvenido en lugar de cerrarlo
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesionForm = new IniciarSesion();
            iniciarSesionForm.Show();
            this.Hide();
        }
    }
}
