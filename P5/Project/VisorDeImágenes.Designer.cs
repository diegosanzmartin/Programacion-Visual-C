
namespace Project
{
    partial class VisorImágenes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menú = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventana = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menú
            // 
            this.Menú.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Ver,
            this.Ventana,
            this.Ayuda});
            this.Menú.Location = new System.Drawing.Point(0, 0);
            this.Menú.MdiWindowListItem = this.Ventana;
            this.Menú.Name = "Menú";
            this.Menú.Size = new System.Drawing.Size(800, 24);
            this.Menú.TabIndex = 0;
            this.Menú.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoSalir,
            this.ArchivoCerrar,
            this.ArchivoNuevo});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(60, 20);
            this.Archivo.Text = "Archivo";
            // 
            // Ver
            // 
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(35, 20);
            this.Ver.Text = "Ver";
            // 
            // Ventana
            // 
            this.Ventana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentanaCascada,
            this.VentanaMosaicoHorizontal,
            this.VentanaMosaicoVertical});
            this.Ventana.Name = "Ventana";
            this.Ventana.Size = new System.Drawing.Size(61, 20);
            this.Ventana.Text = "Ventana";
            // 
            // Ayuda
            // 
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(53, 20);
            this.Ayuda.Text = "Ayuda";
            this.Ayuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // VentanaCascada
            // 
            this.VentanaCascada.Name = "VentanaCascada";
            this.VentanaCascada.Size = new System.Drawing.Size(180, 22);
            this.VentanaCascada.Text = "Cascada";
            this.VentanaCascada.Click += new System.EventHandler(this.VentanaCascada_Click);
            // 
            // VentanaMosaicoHorizontal
            // 
            this.VentanaMosaicoHorizontal.Name = "VentanaMosaicoHorizontal";
            this.VentanaMosaicoHorizontal.Size = new System.Drawing.Size(180, 22);
            this.VentanaMosaicoHorizontal.Text = "Mosaico horizontal";
            this.VentanaMosaicoHorizontal.Click += new System.EventHandler(this.VentanaMosaicoHorizontal_Click);
            // 
            // VentanaMosaicoVertical
            // 
            this.VentanaMosaicoVertical.Name = "VentanaMosaicoVertical";
            this.VentanaMosaicoVertical.Size = new System.Drawing.Size(180, 22);
            this.VentanaMosaicoVertical.Text = "Mosaico vertical";
            this.VentanaMosaicoVertical.Click += new System.EventHandler(this.VentanaMosaicoVertical_Click);
            // 
            // ArchivoSalir
            // 
            this.ArchivoSalir.Name = "ArchivoSalir";
            this.ArchivoSalir.Size = new System.Drawing.Size(180, 22);
            this.ArchivoSalir.Text = "Salir";
            this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
            // 
            // ArchivoCerrar
            // 
            this.ArchivoCerrar.Name = "ArchivoCerrar";
            this.ArchivoCerrar.Size = new System.Drawing.Size(180, 22);
            this.ArchivoCerrar.Text = "Cerrar";
            this.ArchivoCerrar.Click += new System.EventHandler(this.ArchivoCerrar_Click);
            // 
            // ArchivoNuevo
            // 
            this.ArchivoNuevo.Name = "ArchivoNuevo";
            this.ArchivoNuevo.Size = new System.Drawing.Size(180, 22);
            this.ArchivoNuevo.Text = "Nuevo";
            this.ArchivoNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
            // 
            // VisorImágenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menú);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menú;
            this.Name = "VisorImágenes";
            this.Text = "Visor de imágenes";
            this.Menú.ResumeLayout(false);
            this.Menú.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menú;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Ver;
        private System.Windows.Forms.ToolStripMenuItem Ventana;
        private System.Windows.Forms.ToolStripMenuItem Ayuda;
        private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem ArchivoCerrar;
        private System.Windows.Forms.ToolStripMenuItem VentanaCascada;
        private System.Windows.Forms.ToolStripMenuItem VentanaMosaicoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem VentanaMosaicoVertical;
        private System.Windows.Forms.ToolStripMenuItem ArchivoNuevo;
    }
}

