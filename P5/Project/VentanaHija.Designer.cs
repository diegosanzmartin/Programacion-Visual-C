
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenEscalaDeGrises = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenRotar = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAñadirTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenEscalaGrises = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.ImagenEscalaDeGrises});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ArchivoGuardar,
            this.ArchivoGuardarComo});
            this.Archivo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(88, 29);
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
            // ImagenEscalaDeGrises
            // 
            this.ImagenEscalaDeGrises.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImagenAjustar,
            this.ImagenRotar,
            this.ImagenAñadirTexto,
            this.ImagenEscalaGrises});
            this.ImagenEscalaDeGrises.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ImagenEscalaDeGrises.MergeIndex = 2;
            this.ImagenEscalaDeGrises.Name = "ImagenEscalaDeGrises";
            this.ImagenEscalaDeGrises.Size = new System.Drawing.Size(88, 29);
            this.ImagenEscalaDeGrises.Text = "Imagen";
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
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 658);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.m_PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaHija";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaHija_FormClosed);
            this.Resize += new System.EventHandler(this.VentanaHija_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ImagenEscalaDeGrises;
        private System.Windows.Forms.ToolStripMenuItem ImagenAjustar;
        private System.Windows.Forms.ToolStripMenuItem ImagenRotar;
        private System.Windows.Forms.ToolStripMenuItem ImagenAñadirTexto;
        private System.Windows.Forms.ToolStripMenuItem ImagenEscalaGrises;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardarComo;
    }
}