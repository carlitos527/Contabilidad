using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using PollosWeed.Class;
using PollosWeed.Models;

namespace PollosWeed.Forms
{
    public partial class WeedForm : Form
    {
        private readonly WeedRepository _weedRepository;

        public WeedForm()
        {
            InitializeComponent();

            // Inicializa WeedRepository con la cadena de conexión
            string connectionString = ConfigurationManager.ConnectionStrings["PollosWeedConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Cadena de conexión no encontrada.");
                return;
            }
            _weedRepository = new WeedRepository(connectionString);

            // Configura los valores predeterminados para los TextBox
            txtId.Tag = "ID";
            txtProducto.Tag = "Producto";
            txtCantidad.Tag = "Cantidad";
            txtPeso.Tag = "Peso";
            txtPrecio.Tag = "Precio";
            txtIdVenta.Tag = "ID Producto Venta";
            txtCantidadVendida.Tag = "Cantidad Vendida";

            // Carga los datos iniciales en el DataGridView
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                if (_weedRepository == null)
                {
                    MessageBox.Show("Repository no está inicializado.");
                    return;
                }

                var productos = _weedRepository.ObtenerTodos();
                if (productos == null)
                {
                    MessageBox.Show("No se han obtenido productos.");
                    return;
                }

                dataGridViewProductos.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Weed(
                    int.Parse(txtId.Text),
                    txtProducto.Text,
                    int.Parse(txtCantidad.Text),
                    int.Parse(txtPeso.Text),
                    int.Parse(txtPrecio.Text),
                    DateTime.Now // Fecha de inicio es la fecha actual
                );

                _weedRepository.Agregar(producto);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(txtIdVenta.Text);
                int cantidadVendida = int.Parse(txtCantidadVendida.Text);
                DateTime fechaVenta = DateTime.Now;

                _weedRepository.RegistrarVenta(idProducto, cantidadVendida, fechaVenta);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
            }
        }


        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.Text == textBox.Tag.ToString())
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = textBox.Tag.ToString();
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            }
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            using (VentasWeed ventasWeedForm = new VentasWeed())
            {
                // Muestra el nuevo formulario como un cuadro de diálogo modal
                ventasWeedForm.ShowDialog();
            }

            // Este código se ejecutará solo después de que el nuevo formulario se cierre
            // Puedes poner aquí el código para volver a habilitar el formulario actual si es necesario
        }

    }
}
