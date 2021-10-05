
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
            this.OpcionesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAnalogicoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ct_Alarma = new P1.EditHora();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.OpcionesMenu,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salir_Click);
            // 
            // OpcionesMenu
            // 
            this.OpcionesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAnalogicoMenu,
            this.colorFondoToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.OpcionesMenu.Name = "OpcionesMenu";
            this.OpcionesMenu.Size = new System.Drawing.Size(69, 22);
            this.OpcionesMenu.Text = "Opciones";
            this.OpcionesMenu.DropDownOpened += new System.EventHandler(this.OpcionesMenu_DropDownOpened);
            // 
            // mostrarAnalogicoMenu
            // 
            this.mostrarAnalogicoMenu.Checked = true;
            this.mostrarAnalogicoMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarAnalogicoMenu.Name = "mostrarAnalogicoMenu";
            this.mostrarAnalogicoMenu.Size = new System.Drawing.Size(172, 22);
            this.mostrarAnalogicoMenu.Text = "Mostrar Analógico";
            this.mostrarAnalogicoMenu.Click += new System.EventHandler(this.mostrarAnalogicoMenu_Click);
            // 
            // colorFondoToolStripMenuItem
            // 
            this.colorFondoToolStripMenuItem.Name = "colorFondoToolStripMenuItem";
            this.colorFondoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.colorFondoToolStripMenuItem.Text = "Color fondo";
            this.colorFondoToolStripMenuItem.Click += new System.EventHandler(this.colorFondoToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDe);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.AcceptsReturn = true;
            this.ct_HoraActual.Cursor = System.Windows.Forms.Cursors.Default;
            this.ct_HoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_HoraActual.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ct_HoraActual.Location = new System.Drawing.Point(124, 80);
            this.ct_HoraActual.Name = "ct_HoraActual";
            this.ct_HoraActual.ReadOnly = true;
            this.ct_HoraActual.Size = new System.Drawing.Size(100, 24);
            this.ct_HoraActual.TabIndex = 2;
            this.ct_HoraActual.TabStop = false;
            this.ct_HoraActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alarma:";
            // 
            // ct_Alarma
            // 
            this.ct_Alarma.BeepOnError = true;
            this.ct_Alarma.Hora = new System.DateTime(((long)(0)));
            this.ct_Alarma.Location = new System.Drawing.Point(124, 155);
            this.ct_Alarma.Mask = "90:00:99";
            this.ct_Alarma.Name = "ct_Alarma";
            this.ct_Alarma.PromptChar = '-';
            this.ct_Alarma.Size = new System.Drawing.Size(100, 20);
            this.ct_Alarma.TabIndex = 3;
            this.ct_Alarma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Alarma.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(98, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(152, 29);
            this.label.TabIndex = 5;
            this.label.Text = "Hora actual:";
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 221);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_Alarma);
            this.Controls.Add(this.ct_HoraActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem OpcionesMenu;
        private System.Windows.Forms.ToolStripMenuItem mostrarAnalogicoMenu;
        private System.Windows.Forms.ToolStripMenuItem colorFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ct_HoraActual;
        private EditHora ct_Alarma;
        private System.Windows.Forms.Label label;
    }
}

