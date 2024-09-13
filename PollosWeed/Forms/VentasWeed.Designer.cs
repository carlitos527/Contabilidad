namespace PollosWeed.Forms
{
    partial class VentasWeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasWeed));
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewVentas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.RowTemplate.Height = 25;
            this.dataGridViewVentas.Size = new System.Drawing.Size(543, 369);
            this.dataGridViewVentas.TabIndex = 0;
            // 
            // VentasWeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 390);
            this.Controls.Add(this.dataGridViewVentas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "VentasWeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Weed";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridViewVentas;
    }
}
