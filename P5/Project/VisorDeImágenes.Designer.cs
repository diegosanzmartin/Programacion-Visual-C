
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
            this.MenúHerramientas = new System.Windows.Forms.ToolStrip();
            this.ArchivoNuevoIco = new System.Windows.Forms.ToolStripButton();
            this.ArchivoAbrirIco = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AyudaIco = new System.Windows.Forms.ToolStripButton();
            this.etiquietaEstado = new System.Windows.Forms.StatusStrip();
            this.etiquetaEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menú.SuspendLayout();
            this.MenúHerramientas.SuspendLayout();
            this.etiquietaEstado.SuspendLayout();
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
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.ArchivoAbrir_Click);
            // 
            // ArchivoNuevo
            // 
            this.ArchivoNuevo.Name = "ArchivoNuevo";
            this.ArchivoNuevo.Size = new System.Drawing.Size(270, 34);
            this.ArchivoNuevo.Text = "Nuevo";
            this.ArchivoNuevo.Click += new System.EventHandler(this.ArchivoNuevo_Click);
            // 
            // ArchivoCerrar
            // 
            this.ArchivoCerrar.Name = "ArchivoCerrar";
            this.ArchivoCerrar.Size = new System.Drawing.Size(270, 34);
            this.ArchivoCerrar.Text = "Cerrar";
            this.ArchivoCerrar.Click += new System.EventHandler(this.ArchivoCerrar_Click);
            // 
            // ArchivoSalir
            // 
            this.ArchivoSalir.Name = "ArchivoSalir";
            this.ArchivoSalir.Size = new System.Drawing.Size(270, 34);
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
            // MenúHerramientas
            // 
            this.MenúHerramientas.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.MenúHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoNuevoIco,
            this.ArchivoAbrirIco,
            this.toolStripSeparator1,
            this.AyudaIco});
            this.MenúHerramientas.Location = new System.Drawing.Point(0, 33);
            this.MenúHerramientas.Name = "MenúHerramientas";
            this.MenúHerramientas.Size = new System.Drawing.Size(1386, 39);
            this.MenúHerramientas.TabIndex = 2;
            this.MenúHerramientas.Text = "toolStrip1";
            // 
            // ArchivoNuevoIco
            // 
            this.ArchivoNuevoIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ArchivoNuevoIco.Image = ((System.Drawing.Image)(resources.GetObject("ArchivoNuevoIco.Image")));
            this.ArchivoNuevoIco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ArchivoNuevoIco.Name = "ArchivoNuevoIco";
            this.ArchivoNuevoIco.Size = new System.Drawing.Size(34, 34);
            this.ArchivoNuevoIco.Text = "Nuevo";
            this.ArchivoNuevoIco.Click += new System.EventHandler(this.ArchivoNuevo_Click);
            this.ArchivoNuevoIco.MouseEnter += new System.EventHandler(this.ArchivoNuevoIco_MouseEnter);
            this.ArchivoNuevoIco.MouseLeave += new System.EventHandler(this.ArchivoNuevoIco_MouseLeave);
            // 
            // ArchivoAbrirIco
            // 
            this.ArchivoAbrirIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ArchivoAbrirIco.Image = ((System.Drawing.Image)(resources.GetObject("ArchivoAbrirIco.Image")));
            this.ArchivoAbrirIco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ArchivoAbrirIco.Name = "ArchivoAbrirIco";
            this.ArchivoAbrirIco.Size = new System.Drawing.Size(34, 34);
            this.ArchivoAbrirIco.Text = "Abrir";
            this.ArchivoAbrirIco.Click += new System.EventHandler(this.ArchivoAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // AyudaIco
            // 
            this.AyudaIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AyudaIco.Image = ((System.Drawing.Image)(resources.GetObject("AyudaIco.Image")));
            this.AyudaIco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AyudaIco.Name = "AyudaIco";
            this.AyudaIco.Size = new System.Drawing.Size(34, 34);
            this.AyudaIco.Text = "Acerca de";
            this.AyudaIco.Click += new System.EventHandler(this.Ayuda_Click);
            // 
            // etiquietaEstado
            // 
            this.etiquietaEstado.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.etiquietaEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaEstado});
            this.etiquietaEstado.Location = new System.Drawing.Point(0, 912);
            this.etiquietaEstado.Name = "etiquietaEstado";
            this.etiquietaEstado.Size = new System.Drawing.Size(1386, 22);
            this.etiquietaEstado.TabIndex = 4;
            this.etiquietaEstado.Text = "statusStrip1";
            // 
            // etiquetaEstado
            // 
            this.etiquetaEstado.Name = "etiquetaEstado";
            this.etiquetaEstado.Size = new System.Drawing.Size(1371, 15);
            this.etiquetaEstado.Spring = true;
            this.etiquetaEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VisorImágenes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 934);
            this.Controls.Add(this.etiquietaEstado);
            this.Controls.Add(this.MenúHerramientas);
            this.Controls.Add(this.Menú);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menú;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VisorImágenes";
            this.Text = "Visor de imágenes";
            this.MdiChildActivate += new System.EventHandler(this.VisorImágenes_MdiChildActivate);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VisorImágenes_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VisorImágenes_DragEnter);
            this.Menú.ResumeLayout(false);
            this.Menú.PerformLayout();
            this.MenúHerramientas.ResumeLayout(false);
            this.MenúHerramientas.PerformLayout();
            this.etiquietaEstado.ResumeLayout(false);
            this.etiquietaEstado.PerformLayout();
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
        private System.Windows.Forms.ToolStrip MenúHerramientas;
        private System.Windows.Forms.ToolStripButton ArchivoNuevoIco;
        private System.Windows.Forms.ToolStripButton ArchivoAbrirIco;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AyudaIco;
        private System.Windows.Forms.StatusStrip etiquietaEstado;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaEstado;
    }
}

