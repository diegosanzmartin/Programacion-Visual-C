
namespace P1
{
    partial class RelojDigital
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelojDigital));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bt_Mostrar = new System.Windows.Forms.Button();
            this.bt_ColorFondo = new System.Windows.Forms.Button();
            this.bt_Fuente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salir_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDe);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora actual:";
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.AcceptsReturn = true;
            this.ct_HoraActual.Cursor = System.Windows.Forms.Cursors.Default;
            this.ct_HoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_HoraActual.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ct_HoraActual.Location = new System.Drawing.Point(284, 171);
            this.ct_HoraActual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ct_HoraActual.Name = "ct_HoraActual";
            this.ct_HoraActual.ReadOnly = true;
            this.ct_HoraActual.Size = new System.Drawing.Size(148, 32);
            this.ct_HoraActual.TabIndex = 2;
            this.ct_HoraActual.TabStop = false;
            this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bt_Mostrar
            // 
            this.bt_Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Mostrar.Location = new System.Drawing.Point(258, 287);
            this.bt_Mostrar.Name = "bt_Mostrar";
            this.bt_Mostrar.Size = new System.Drawing.Size(200, 39);
            this.bt_Mostrar.TabIndex = 3;
            this.bt_Mostrar.Text = "Text";
            this.bt_Mostrar.UseVisualStyleBackColor = true;
            this.bt_Mostrar.Click += new System.EventHandler(this.bt_Mostrar_Click);
            // 
            // bt_ColorFondo
            // 
            this.bt_ColorFondo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ColorFondo.Location = new System.Drawing.Point(384, 355);
            this.bt_ColorFondo.Name = "bt_ColorFondo";
            this.bt_ColorFondo.Size = new System.Drawing.Size(109, 31);
            this.bt_ColorFondo.TabIndex = 4;
            this.bt_ColorFondo.Text = "Color fondo";
            this.bt_ColorFondo.UseVisualStyleBackColor = true;
            this.bt_ColorFondo.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Fuente
            // 
            this.bt_Fuente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Fuente.Location = new System.Drawing.Point(232, 355);
            this.bt_Fuente.Name = "bt_Fuente";
            this.bt_Fuente.Size = new System.Drawing.Size(85, 31);
            this.bt_Fuente.TabIndex = 5;
            this.bt_Fuente.Text = "Fuente";
            this.bt_Fuente.UseVisualStyleBackColor = true;
            this.bt_Fuente.Click += new System.EventHandler(this.button2_Click);
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 443);
            this.Controls.Add(this.bt_Fuente);
            this.Controls.Add(this.bt_ColorFondo);
            this.Controls.Add(this.bt_Mostrar);
            this.Controls.Add(this.ct_HoraActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "RelojDigital";
            this.Text = "Reloj Digital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ct_HoraActual;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button bt_Mostrar;
        private System.Windows.Forms.Button bt_ColorFondo;
        private System.Windows.Forms.Button bt_Fuente;
    }
}

