
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
            this.ImagenEscalaDeGrises = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAjustar = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenRotar = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenAñadirTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(100, 50);
            this.m_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.m_PictureBox.TabIndex = 0;
            this.m_PictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImagenEscalaDeGrises});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // ImagenEscalaDeGrises
            // 
            this.ImagenEscalaDeGrises.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImagenAjustar,
            this.ImagenRotar,
            this.ImagenAñadirTexto,
            this.escalaDeGrisesToolStripMenuItem});
            this.ImagenEscalaDeGrises.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ImagenEscalaDeGrises.MergeIndex = 2;
            this.ImagenEscalaDeGrises.Name = "ImagenEscalaDeGrises";
            this.ImagenEscalaDeGrises.Size = new System.Drawing.Size(59, 20);
            this.ImagenEscalaDeGrises.Text = "Imagen";
            // 
            // ImagenAjustar
            // 
            this.ImagenAjustar.Name = "ImagenAjustar";
            this.ImagenAjustar.Size = new System.Drawing.Size(180, 22);
            this.ImagenAjustar.Text = "Ajustar Ventana";
            this.ImagenAjustar.Click += new System.EventHandler(this.ImagenAjustar_Click);
            // 
            // ImagenRotar
            // 
            this.ImagenRotar.Name = "ImagenRotar";
            this.ImagenRotar.Size = new System.Drawing.Size(180, 22);
            this.ImagenRotar.Text = "Rotar 90º";
            this.ImagenRotar.Click += new System.EventHandler(this.ImagenRotar_Click);
            // 
            // ImagenAñadirTexto
            // 
            this.ImagenAñadirTexto.Name = "ImagenAñadirTexto";
            this.ImagenAñadirTexto.Size = new System.Drawing.Size(180, 22);
            this.ImagenAñadirTexto.Text = "Añadir Texto";
            this.ImagenAñadirTexto.Click += new System.EventHandler(this.ImagenAñadirTexto_Click);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // VentanaHija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 428);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.m_PictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaHija";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form2";
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
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
    }
}