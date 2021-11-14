
namespace Project
{
    partial class VentanaHija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaHija));
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            this.MenúHijo = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.Imagen = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenRotar = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAñadirTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenEscalaGrises = new System.Windows.Forms.ToolStripMenuItem();
            this.MenúHerramientasHijo = new System.Windows.Forms.ToolStrip();
            this.ArchivoGuardarIco = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ImagenAjustarIco = new System.Windows.Forms.ToolStripButton();
            this.ImagenBNIco = new System.Windows.Forms.ToolStripButton();
            this.ImagenRotarIco = new System.Windows.Forms.ToolStripButton();
            this.ImagenAñadirTextoIco = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.MenúHijo.SuspendLayout();
            this.MenúHerramientasHijo.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_PictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(100, 50);
            this.m_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            // 
            // MenúHijo
            // 
            this.MenúHijo.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenúHijo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenúHijo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Imagen});
            this.MenúHijo.Location = new System.Drawing.Point(0, 0);
            this.MenúHijo.Name = "MenúHijo";
            this.MenúHijo.Size = new System.Drawing.Size(880, 33);
            this.MenúHijo.TabIndex = 1;
            this.MenúHijo.Text = "menuStrip1";
            this.MenúHijo.Visible = false;
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ArchivoGuardar,
            this.ArchivoGuardarComo});
            this.Archivo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(88, 27);
            this.Archivo.Text = "Archivo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem1.MergeIndex = 3;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // ArchivoGuardar
            // 
            this.ArchivoGuardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ArchivoGuardar.MergeIndex = 4;
            this.ArchivoGuardar.Name = "ArchivoGuardar";
            this.ArchivoGuardar.Size = new System.Drawing.Size(231, 34);
            this.ArchivoGuardar.Text = "Guardar";
            this.ArchivoGuardar.Click += new System.EventHandler(this.ArchivoGuardar_Click);
            // 
            // ArchivoGuardarComo
            // 
            this.ArchivoGuardarComo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ArchivoGuardarComo.MergeIndex = 5;
            this.ArchivoGuardarComo.Name = "ArchivoGuardarComo";
            this.ArchivoGuardarComo.Size = new System.Drawing.Size(231, 34);
            this.ArchivoGuardarComo.Text = "Gurdar como...";
            this.ArchivoGuardarComo.Click += new System.EventHandler(this.ArchivoGuardarComo_Click);
            // 
            // Imagen
            // 
            this.Imagen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImagenAjustar,
            this.ImagenRotar,
            this.ImagenAñadirTexto,
            this.ImagenEscalaGrises});
            this.Imagen.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.Imagen.MergeIndex = 2;
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(88, 27);
            this.Imagen.Text = "Imagen";
            // 
            // ImagenAjustar
            // 
            this.ImagenAjustar.Name = "ImagenAjustar";
            this.ImagenAjustar.Size = new System.Drawing.Size(237, 34);
            this.ImagenAjustar.Text = "Ajustar Ventana";
            this.ImagenAjustar.Click += new System.EventHandler(this.ImagenAjustar_Click);
            // 
            // ImagenRotar
            // 
            this.ImagenRotar.Name = "ImagenRotar";
            this.ImagenRotar.Size = new System.Drawing.Size(237, 34);
            this.ImagenRotar.Text = "Rotar 90º";
            this.ImagenRotar.Click += new System.EventHandler(this.ImagenRotar_Click);
            // 
            // ImagenAñadirTexto
            // 
            this.ImagenAñadirTexto.Name = "ImagenAñadirTexto";
            this.ImagenAñadirTexto.Size = new System.Drawing.Size(237, 34);
            this.ImagenAñadirTexto.Text = "Añadir Texto";
            this.ImagenAñadirTexto.Click += new System.EventHandler(this.ImagenAñadirTexto_Click);
            // 
            // ImagenEscalaGrises
            // 
            this.ImagenEscalaGrises.Name = "ImagenEscalaGrises";
            this.ImagenEscalaGrises.Size = new System.Drawing.Size(237, 34);
            this.ImagenEscalaGrises.Text = "Escala de grises";
            this.ImagenEscalaGrises.Click += new System.EventHandler(this.ImagenEscalaGrises_Click);
            // 
            // MenúHerramientasHijo
            // 
            this.MenúHerramientasHijo.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.MenúHerramientasHijo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoGuardarIco,
            this.toolStripSeparator1,
            this.ImagenAjustarIco,
            this.ImagenBNIco,
            this.ImagenRotarIco,
            this.ImagenAñadirTextoIco});
            this.MenúHerramientasHijo.Location = new System.Drawing.Point(0, 0);
            this.MenúHerramientasHijo.Name = "MenúHerramientasHijo";
            this.MenúHerramientasHijo.Size = new System.Drawing.Size(880, 39);
            this.MenúHerramientasHijo.TabIndex = 2;
            this.MenúHerramientasHijo.Text = "toolStrip1";
            this.MenúHerramientasHijo.Visible = false;
            // 
            // ArchivoGuardarIco
            // 
            this.ArchivoGuardarIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ArchivoGuardarIco.Image = ((System.Drawing.Image)(resources.GetObject("ArchivoGuardarIco.Image")));
            this.ArchivoGuardarIco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ArchivoGuardarIco.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ArchivoGuardarIco.MergeIndex = 2;
            this.ArchivoGuardarIco.Name = "ArchivoGuardarIco";
            this.ArchivoGuardarIco.Size = new System.Drawing.Size(34, 34);
            this.ArchivoGuardarIco.Text = "ArchivoGuardar";
            this.ArchivoGuardarIco.Click += new System.EventHandler(this.ArchivoGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 3;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ImagenAjustarIco
            // 
            this.ImagenAjustarIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImagenAjustarIco.Image = ((System.Drawing.Image)(resources.GetObject("ImagenAjustarIco.Image")));
            this.ImagenAjustarIco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImagenAjustarIco.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ImagenAjustarIco.MergeIndex = 4;
            this.ImagenAjustarIco.Name = "ImagenAjustarIco";
            this.ImagenAjustarIco.Size = new System.Drawing.Size(34, 34);
            this.ImagenAjustarIco.Text = "Ajustar a ventana";
            this.ImagenAjustarIco.Click += new System.EventHandler(this.ImagenAjustar_Click);
            // 
            // ImagenBNIco
            // 
            this.ImagenBNIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImagenBNIco.Image = ((System.Drawing.Image)(resources.GetObject("ImagenBNIco.Image")));
            this.ImagenBNIco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImagenBNIco.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ImagenBNIco.MergeIndex = 5;
            this.ImagenBNIco.Name = "ImagenBNIco";
            this.ImagenBNIco.Size = new System.Drawing.Size(34, 34);
            this.ImagenBNIco.Text = "Imagen blanco y negro";
            this.ImagenBNIco.Click += new System.EventHandler(this.ImagenEscalaGrises_Click);
            // 
            // ImagenRotarIco
            // 
            this.ImagenRotarIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImagenRotarIco.Image = ((System.Drawing.Image)(resources.GetObject("ImagenRotarIco.Image")));
            this.ImagenRotarIco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImagenRotarIco.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ImagenRotarIco.MergeIndex = 6;
            this.ImagenRotarIco.Name = "ImagenRotarIco";
            this.ImagenRotarIco.Size = new System.Drawing.Size(34, 34);
            this.ImagenRotarIco.Text = "Rotar 90º";
            this.ImagenRotarIco.Click += new System.EventHandler(this.ImagenRotar_Click);
            // 
            // ImagenAñadirTextoIco
            // 
            this.ImagenAñadirTextoIco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ImagenAñadirTextoIco.Image = ((System.Drawing.Image)(resources.GetObject("ImagenAñadirTextoIco.Image")));
            this.ImagenAñadirTextoIco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImagenAñadirTextoIco.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ImagenAñadirTextoIco.MergeIndex = 7;
            this.ImagenAñadirTextoIco.Name = "ImagenAñadirTextoIco";
            this.ImagenAñadirTextoIco.Size = new System.Drawing.Size(34, 34);
            this.ImagenAñadirTextoIco.Text = "Añadir texto";
            this.ImagenAñadirTextoIco.Click += new System.EventHandler(this.ImagenAñadirTexto_Click);
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 658);
            this.Controls.Add(this.MenúHijo);
            this.Controls.Add(this.MenúHerramientasHijo);
            this.Controls.Add(this.m_PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenúHijo;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaHija";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaHija_FormClosed);
            this.Resize += new System.EventHandler(this.VentanaHija_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.MenúHijo.ResumeLayout(false);
            this.MenúHijo.PerformLayout();
            this.MenúHerramientasHijo.ResumeLayout(false);
            this.MenúHerramientasHijo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.MenuStrip MenúHijo;
        private System.Windows.Forms.ToolStripMenuItem Imagen;
        private System.Windows.Forms.ToolStripMenuItem ImagenAjustar;
        private System.Windows.Forms.ToolStripMenuItem ImagenRotar;
        private System.Windows.Forms.ToolStripMenuItem ImagenAñadirTexto;
        private System.Windows.Forms.ToolStripMenuItem ImagenEscalaGrises;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardarComo;
        public System.Windows.Forms.ToolStrip MenúHerramientasHijo;
        private System.Windows.Forms.ToolStripButton ArchivoGuardarIco;
        private System.Windows.Forms.ToolStripButton ImagenAjustarIco;
        private System.Windows.Forms.ToolStripButton ImagenBNIco;
        private System.Windows.Forms.ToolStripButton ImagenRotarIco;
        private System.Windows.Forms.ToolStripButton ImagenAñadirTextoIco;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}