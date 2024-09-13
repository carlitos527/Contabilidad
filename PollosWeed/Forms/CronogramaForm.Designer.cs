namespace PollosWeed.Forms
{
    partial class CronogramaForm
    {
        private System.ComponentModel.IContainer components = null;

        // Limpiar recursos
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Form

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CronogramaForm));
            this.txtPollosId = new System.Windows.Forms.TextBox();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.txtInsumosId = new System.Windows.Forms.TextBox();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.txtLunes = new System.Windows.Forms.TextBox();
            this.txtMartes = new System.Windows.Forms.TextBox();
            this.txtMiercoles = new System.Windows.Forms.TextBox();
            this.txtJueves = new System.Windows.Forms.TextBox();
            this.txtViernes = new System.Windows.Forms.TextBox();
            this.txtSabado = new System.Windows.Forms.TextBox();
            this.txtDomingo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarPollo = new System.Windows.Forms.Button();
            this.btnBuscarInsumos = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvCronograma = new System.Windows.Forms.DataGridView();
            this.lblPollosId = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblInsumosId = new System.Windows.Forms.Label();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblLunes = new System.Windows.Forms.Label();
            this.lblMartes = new System.Windows.Forms.Label();
            this.lblMiercoles = new System.Windows.Forms.Label();
            this.lblJueves = new System.Windows.Forms.Label();
            this.lblViernes = new System.Windows.Forms.Label();
            this.lblSabado = new System.Windows.Forms.Label();
            this.lblDomingo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPollosId
            // 
            this.txtPollosId.Location = new System.Drawing.Point(29, 36);
            this.txtPollosId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPollosId.Name = "txtPollosId";
            this.txtPollosId.Size = new System.Drawing.Size(31, 20);
            this.txtPollosId.TabIndex = 0;
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(104, 36);
            this.txtTipoProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(142, 20);
            this.txtTipoProducto.TabIndex = 1;
            // 
            // txtInsumosId
            // 
            this.txtInsumosId.Location = new System.Drawing.Point(29, 91);
            this.txtInsumosId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInsumosId.Name = "txtInsumosId";
            this.txtInsumosId.Size = new System.Drawing.Size(31, 20);
            this.txtInsumosId.TabIndex = 2;
            // 
            // txtInsumo
            // 
            this.txtInsumo.Location = new System.Drawing.Point(104, 91);
            this.txtInsumo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(154, 20);
            this.txtInsumo.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(13, 138);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtSemana
            // 
            this.txtSemana.Location = new System.Drawing.Point(77, 217);
            this.txtSemana.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(31, 20);
            this.txtSemana.TabIndex = 5;
            // 
            // txtLunes
            // 
            this.txtLunes.Location = new System.Drawing.Point(63, 249);
            this.txtLunes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLunes.Name = "txtLunes";
            this.txtLunes.Size = new System.Drawing.Size(232, 20);
            this.txtLunes.TabIndex = 6;
            // 
            // txtMartes
            // 
            this.txtMartes.Location = new System.Drawing.Point(63, 286);
            this.txtMartes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMartes.Name = "txtMartes";
            this.txtMartes.Size = new System.Drawing.Size(232, 20);
            this.txtMartes.TabIndex = 7;
            // 
            // txtMiercoles
            // 
            this.txtMiercoles.Location = new System.Drawing.Point(83, 315);
            this.txtMiercoles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMiercoles.Name = "txtMiercoles";
            this.txtMiercoles.Size = new System.Drawing.Size(212, 20);
            this.txtMiercoles.TabIndex = 8;
            // 
            // txtJueves
            // 
            this.txtJueves.Location = new System.Drawing.Point(71, 349);
            this.txtJueves.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtJueves.Name = "txtJueves";
            this.txtJueves.Size = new System.Drawing.Size(224, 20);
            this.txtJueves.TabIndex = 9;
            // 
            // txtViernes
            // 
            this.txtViernes.Location = new System.Drawing.Point(71, 381);
            this.txtViernes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtViernes.Name = "txtViernes";
            this.txtViernes.Size = new System.Drawing.Size(224, 20);
            this.txtViernes.TabIndex = 10;
            // 
            // txtSabado
            // 
            this.txtSabado.Location = new System.Drawing.Point(71, 413);
            this.txtSabado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSabado.Name = "txtSabado";
            this.txtSabado.Size = new System.Drawing.Size(224, 20);
            this.txtSabado.TabIndex = 11;
            // 
            // txtDomingo
            // 
            this.txtDomingo.Location = new System.Drawing.Point(77, 444);
            this.txtDomingo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDomingo.Name = "txtDomingo";
            this.txtDomingo.Size = new System.Drawing.Size(218, 20);
            this.txtDomingo.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(13, 181);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(245, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // btnBuscarPollo
            // 
            this.btnBuscarPollo.Location = new System.Drawing.Point(266, 33);
            this.btnBuscarPollo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarPollo.Name = "btnBuscarPollo";
            this.btnBuscarPollo.Size = new System.Drawing.Size(29, 23);
            this.btnBuscarPollo.TabIndex = 15;
            this.btnBuscarPollo.Text = "🔍";
            this.btnBuscarPollo.UseVisualStyleBackColor = true;
            this.btnBuscarPollo.Click += new System.EventHandler(this.btnBuscarPollo_Click);
            // 
            // btnBuscarInsumos
            // 
            this.btnBuscarInsumos.Location = new System.Drawing.Point(158, 136);
            this.btnBuscarInsumos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarInsumos.Name = "btnBuscarInsumos";
            this.btnBuscarInsumos.Size = new System.Drawing.Size(29, 23);
            this.btnBuscarInsumos.TabIndex = 16;
            this.btnBuscarInsumos.Text = "🔎";
            this.btnBuscarInsumos.UseVisualStyleBackColor = true;
            this.btnBuscarInsumos.Click += new System.EventHandler(this.btnBuscarInsumos_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(104, 522);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvCronograma
            // 
            this.dgvCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCronograma.Location = new System.Drawing.Point(329, 12);
            this.dgvCronograma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCronograma.Name = "dgvCronograma";
            this.dgvCronograma.Size = new System.Drawing.Size(844, 562);
            this.dgvCronograma.TabIndex = 18;
            // 
            // lblPollosId
            // 
            this.lblPollosId.AutoSize = true;
            this.lblPollosId.Location = new System.Drawing.Point(22, 20);
            this.lblPollosId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPollosId.Name = "lblPollosId";
            this.lblPollosId.Size = new System.Drawing.Size(62, 13);
            this.lblPollosId.TabIndex = 19;
            this.lblPollosId.Text = "ID Pollos:";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(124, 20);
            this.lblTipoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(109, 13);
            this.lblTipoProducto.TabIndex = 20;
            this.lblTipoProducto.Text = "Tipo de Producto:";
            // 
            // lblInsumosId
            // 
            this.lblInsumosId.AutoSize = true;
            this.lblInsumosId.Location = new System.Drawing.Point(20, 75);
            this.lblInsumosId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsumosId.Name = "lblInsumosId";
            this.lblInsumosId.Size = new System.Drawing.Size(74, 13);
            this.lblInsumosId.TabIndex = 21;
            this.lblInsumosId.Text = "ID Insumos:";
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Location = new System.Drawing.Point(136, 75);
            this.lblInsumo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(51, 13);
            this.lblInsumo.TabIndex = 22;
            this.lblInsumo.Text = "Insumo:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(16, 122);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Location = new System.Drawing.Point(10, 217);
            this.lblSemana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(56, 13);
            this.lblSemana.TabIndex = 24;
            this.lblSemana.Text = "Semana:";
            // 
            // lblLunes
            // 
            this.lblLunes.AutoSize = true;
            this.lblLunes.Location = new System.Drawing.Point(10, 252);
            this.lblLunes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLunes.Name = "lblLunes";
            this.lblLunes.Size = new System.Drawing.Size(45, 13);
            this.lblLunes.TabIndex = 25;
            this.lblLunes.Text = "Lunes:";
            // 
            // lblMartes
            // 
            this.lblMartes.AutoSize = true;
            this.lblMartes.Location = new System.Drawing.Point(10, 289);
            this.lblMartes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMartes.Name = "lblMartes";
            this.lblMartes.Size = new System.Drawing.Size(49, 13);
            this.lblMartes.TabIndex = 26;
            this.lblMartes.Text = "Martes:";
            // 
            // lblMiercoles
            // 
            this.lblMiercoles.AutoSize = true;
            this.lblMiercoles.Location = new System.Drawing.Point(10, 322);
            this.lblMiercoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiercoles.Name = "lblMiercoles";
            this.lblMiercoles.Size = new System.Drawing.Size(65, 13);
            this.lblMiercoles.TabIndex = 27;
            this.lblMiercoles.Text = "Miércoles:";
            // 
            // lblJueves
            // 
            this.lblJueves.AutoSize = true;
            this.lblJueves.Location = new System.Drawing.Point(10, 356);
            this.lblJueves.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJueves.Name = "lblJueves";
            this.lblJueves.Size = new System.Drawing.Size(51, 13);
            this.lblJueves.TabIndex = 28;
            this.lblJueves.Text = "Jueves:";
            // 
            // lblViernes
            // 
            this.lblViernes.AutoSize = true;
            this.lblViernes.Location = new System.Drawing.Point(10, 388);
            this.lblViernes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViernes.Name = "lblViernes";
            this.lblViernes.Size = new System.Drawing.Size(53, 13);
            this.lblViernes.TabIndex = 29;
            this.lblViernes.Text = "Viernes:";
            // 
            // lblSabado
            // 
            this.lblSabado.AutoSize = true;
            this.lblSabado.Location = new System.Drawing.Point(10, 416);
            this.lblSabado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(54, 13);
            this.lblSabado.TabIndex = 30;
            this.lblSabado.Text = "Sábado:";
            // 
            // lblDomingo
            // 
            this.lblDomingo.AutoSize = true;
            this.lblDomingo.Location = new System.Drawing.Point(10, 451);
            this.lblDomingo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomingo.Name = "lblDomingo";
            this.lblDomingo.Size = new System.Drawing.Size(60, 13);
            this.lblDomingo.TabIndex = 31;
            this.lblDomingo.Text = "Domingo:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(14, 165);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 32;
            this.lblFecha.Text = "Fecha:";
            // 
            // CronogramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 616);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDomingo);
            this.Controls.Add(this.lblSabado);
            this.Controls.Add(this.lblViernes);
            this.Controls.Add(this.lblJueves);
            this.Controls.Add(this.lblMiercoles);
            this.Controls.Add(this.lblMartes);
            this.Controls.Add(this.lblLunes);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblInsumo);
            this.Controls.Add(this.lblInsumosId);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.lblPollosId);
            this.Controls.Add(this.dgvCronograma);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscarInsumos);
            this.Controls.Add(this.btnBuscarPollo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDomingo);
            this.Controls.Add(this.txtSabado);
            this.Controls.Add(this.txtViernes);
            this.Controls.Add(this.txtJueves);
            this.Controls.Add(this.txtMiercoles);
            this.Controls.Add(this.txtMartes);
            this.Controls.Add(this.txtLunes);
            this.Controls.Add(this.txtSemana);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtInsumo);
            this.Controls.Add(this.txtInsumosId);
            this.Controls.Add(this.txtTipoProducto);
            this.Controls.Add(this.txtPollosId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CronogramaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronograma";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPollosId;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.TextBox txtInsumosId;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtSemana;
        private System.Windows.Forms.TextBox txtLunes;
        private System.Windows.Forms.TextBox txtMartes;
        private System.Windows.Forms.TextBox txtMiercoles;
        private System.Windows.Forms.TextBox txtJueves;
        private System.Windows.Forms.TextBox txtViernes;
        private System.Windows.Forms.TextBox txtSabado;
        private System.Windows.Forms.TextBox txtDomingo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscarPollo;
        private System.Windows.Forms.Button btnBuscarInsumos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCronograma;

        // Etiquetas
        private System.Windows.Forms.Label lblPollosId;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblInsumosId;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label lblLunes;
        private System.Windows.Forms.Label lblMartes;
        private System.Windows.Forms.Label lblMiercoles;
        private System.Windows.Forms.Label lblJueves;
        private System.Windows.Forms.Label lblViernes;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Label lblDomingo;
        private System.Windows.Forms.Label lblFecha;
    }
}
