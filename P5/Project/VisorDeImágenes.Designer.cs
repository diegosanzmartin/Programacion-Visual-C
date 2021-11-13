
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorImágenes));
            this.Menú = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventana = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.Menú.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menú
            // 
            this.Menú.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menú.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menú.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Ver,
            this.Ventana,
            this.Ayuda});
            this.Menú.Location = new System.Drawing.Point(0, 0);
            this.Menú.MdiWindowListItem = this.Ventana;
            this.Menú.Name = "Menú";
            this.Menú.Size = new System.Drawing.Size(1386, 33);
            this.Menú.TabIndex = 0;
            this.Menú.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.ArchivoNuevo,
            this.ArchivoCerrar,
            this.ArchivoSalir});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(88, 29);
            this.Archivo.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(166, 34);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.ArchivoAbrir_Click);
            // 
            // ArchivoNuevo
            // 
            this.ArchivoNuevo.Name = "ArchivoNuevo";
            this.ArchivoNuevo.Size = new System.Drawing.Size(166, 34);
            this.ArchivoNuevo.Text = "Nuevo";
            this.ArchivoNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
            // 
            // ArchivoCerrar
            // 
            this.ArchivoCerrar.Name = "ArchivoCerrar";
            this.ArchivoCerrar.Size = new System.Drawing.Size(166, 34);
            this.ArchivoCerrar.Text = "Cerrar";
            this.ArchivoCerrar.Click += new System.EventHandler(this.ArchivoCerrar_Click);
            // 
            // ArchivoSalir
            // 
            this.ArchivoSalir.Name = "ArchivoSalir";
            this.ArchivoSalir.Size = new System.Drawing.Size(166, 34);
            this.ArchivoSalir.Text = "Salir";
            this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
            // 
            // Ver
            // 
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(53, 29);
            this.Ver.Text = "Ver";
            // 
            // Ventana
            // 
            this.Ventana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentanaCascada,
            this.VentanaMosaicoHorizontal,
            this.VentanaMosaicoVertical});
            this.Ventana.Name = "Ventana";
            this.Ventana.Size = new System.Drawing.Size(91, 29);
            this.Ventana.Text = "Ventana";
            // 
            // VentanaCascada
            // 
            this.VentanaCascada.Name = "VentanaCascada";
            this.VentanaCascada.Size = new System.Drawing.Size(265, 34);
            this.VentanaCascada.Text = "Cascada";
            this.VentanaCascada.Click += new System.EventHandler(this.VentanaCascada_Click);
            // 
            // VentanaMosaicoHorizontal
            // 
            this.VentanaMosaicoHorizontal.Name = "VentanaMosaicoHorizontal";
            this.VentanaMosaicoHorizontal.Size = new System.Drawing.Size(265, 34);
            this.VentanaMosaicoHorizontal.Text = "Mosaico horizontal";
            this.VentanaMosaicoHorizontal.Click += new System.EventHandler(this.VentanaMosaicoHorizontal_Click);
            // 
            // VentanaMosaicoVertical
            // 
            this.VentanaMosaicoVertical.Name = "VentanaMosaicoVertical";
            this.VentanaMosaicoVertical.Size = new System.Drawing.Size(265, 34);
            this.VentanaMosaicoVertical.Text = "Mosaico vertical";
            this.VentanaMosaicoVertical.Click += new System.EventHandler(this.VentanaMosaicoVertical_Click);
            // 
            // Ayuda
            // 
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(79, 29);
            this.Ayuda.Text = "Ayuda";
            this.Ayuda.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // VisorImágenes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 934);
            this.Controls.Add(this.Menú);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menú;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VisorImágenes";
            this.Text = "Visor de imágenes";
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VisorImágenes_DragEnter);
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
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    }
}

