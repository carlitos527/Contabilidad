using System;
using System.Windows.Forms;

namespace PollosWeed.Forms
{
    public partial class Contabilidad : Form
    {
        public Contabilidad()
        {
            InitializeComponent();
        }

        private void Weed_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario WeedForm
            WeedForm weedForm = new WeedForm();

            // Mostrar el formulario WeedForm como un diálogo modal
            weedForm.ShowDialog();

            // El formulario Contabilidad sigue abierto después de que WeedForm se cierra
        }

        private void Pollos_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario PollosForm
            PollosForm pollosForm = new PollosForm();

            // Mostrar el formulario PollosForm como un diálogo modal
            pollosForm.ShowDialog();

            // El formulario Contabilidad sigue abierto después de que PollosForm se cierra
        }

        private void Insumos_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario InsumosForm
            InsumosForm insumosForm = new InsumosForm();

            // Mostrar el formulario InsumosForm como un diálogo modal
            insumosForm.ShowDialog();

            // El formulario Contabilidad sigue abierto después de que InsumosForm se cierra
        }

        private void Cronograma_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario CronogramaForm
            CronogramaForm cronogramaForm = new CronogramaForm();

            // Mostrar el formulario CronogramaForm como un diálogo modal
            cronogramaForm.ShowDialog();

            // El formulario CronogramaForm sigue abierto después de que CronogramaForm se cierra

        }
    }
}
