namespace PollosWeed
{
    partial class PollosForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PollosForm));
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.numPesoUnitario = new System.Windows.Forms.NumericUpDown();
            this.numPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewPollos = new System.Windows.Forms.DataGridView();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPesoUnitario = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnActualizarFechaFin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPollos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.Location = new System.Drawing.Point(140, 21);
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(151, 20);
            this.txtTipoProducto.TabIndex = 0;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(140, 61);
            this.numCantidad.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(88, 20);
            this.numCantidad.TabIndex = 1;
            // 
            // numPesoUnitario
            // 
            this.numPesoUnitario.Location = new System.Drawing.Point(140, 89);
            this.numPesoUnitario.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPesoUnitario.Name = "numPesoUnitario";
            this.numPesoUnitario.Size = new System.Drawing.Size(88, 20);
            this.numPesoUnitario.TabIndex = 2;
            // 
            // numPrecioUnitario
            // 
            this.numPrecioUnitario.Location = new System.Drawing.Point(140, 117);
            this.numPrecioUnitario.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numPrecioUnitario.Name = "numPrecioUnitario";
            this.numPrecioUnitario.Size = new System.Drawing.Size(89, 20);
            this.numPrecioUnitario.TabIndex = 3;
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(141, 168);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaInicio.TabIndex = 4;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(140, 201);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFechaFin.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(12, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 24);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar Pollo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewPollos
            // 
            this.dataGridViewPollos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPollos.Location = new System.Drawing.Point(298, 12);
            this.dataGridViewPollos.Name = "dataGridViewPollos";
            this.dataGridViewPollos.Size = new System.Drawing.Size(724, 312);
            this.dataGridViewPollos.TabIndex = 7;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoProducto.Location = new System.Drawing.Point(9, 24);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(105, 13);
            this.lblTipoProducto.TabIndex = 8;
            this.lblTipoProducto.Text = "Tipo de Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(57, 61);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPesoUnitario
            // 
            this.lblPesoUnitario.AutoSize = true;
            this.lblPesoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPesoUnitario.Location = new System.Drawing.Point(31, 96);
            this.lblPesoUnitario.Name = "lblPesoUnitario";
            this.lblPesoUnitario.Size = new System.Drawing.Size(83, 13);
            this.lblPesoUnitario.TabIndex = 10;
            this.lblPesoUnitario.Text = "Peso Unitario";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrecioUnitario.Location = new System.Drawing.Point(22, 124);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(91, 13);
            this.lblPrecioUnitario.TabIndex = 11;
            this.lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaInicio.Location = new System.Drawing.Point(37, 175);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(77, 13);
            this.lblFechaInicio.TabIndex = 12;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaFin.Location = new System.Drawing.Point(51, 208);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(63, 13);
            this.lblFechaFin.TabIndex = 13;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // btnActualizarFechaFin
            // 
            this.btnActualizarFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizarFechaFin.Location = new System.Drawing.Point(140, 253);
            this.btnActualizarFechaFin.Name = "btnActualizarFechaFin";
            this.btnActualizarFechaFin.Size = new System.Drawing.Size(139, 24);
            this.btnActualizarFechaFin.TabIndex = 14;
            this.btnActualizarFechaFin.Text = "Actualizar Fecha Fin";
            this.btnActualizarFechaFin.UseVisualStyleBackColor = true;
            this.btnActualizarFechaFin.Click += new System.EventHandler(this.btnActualizarFechaFin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Kill_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(39, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ventas 🛒";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.VentasPollo_Click);
            // 
            // PollosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizarFechaFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblPesoUnitario);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.dataGridViewPollos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dateTimePickerFechaFin);
            this.Controls.Add(this.dateTimePickerFechaInicio);
            this.Controls.Add(this.numPrecioUnitario);
            this.Controls.Add(this.numPesoUnitario);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.txtTipoProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PollosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Pollos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PollosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPesoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPollos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.NumericUpDown numPesoUnitario;
        private System.Windows.Forms.NumericUpDown numPrecioUnitario;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridViewPollos;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPesoUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnActualizarFechaFin; // Botón nuevo para actualizar la fecha fin
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
