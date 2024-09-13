using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using PollosWeed.Class;

namespace PollosWeed.Forms
{
    public partial class VentasWeed : Form
    {
        private readonly VentaRepository _ventaRepository;

        public VentasWeed()
        {
            InitializeComponent();

            // Inicializa VentaRepository con la cadena de conexión
            string connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Cadena de conexión no encontrada.");
                return;
            }
            _ventaRepository = new VentaRepository(connectionString);

            // Carga los datos iniciales en el DataGridView
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                if (_ventaRepository == null)
                {
                    MessageBox.Show("Repository no está inicializado.");
                    return;
                }

                var ventas = _ventaRepository.ObtenerTodasLasVentas();
                if (ventas == null)
                {
                    MessageBox.Show("No se han obtenido ventas.");
                    return;
                }

                dataGridViewVentas.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
