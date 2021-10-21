
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.despertadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZona = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ct_HoraActual = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.bt_ZonaHoraria_Click = new System.Windows.Forms.Button();
            this.menuContextoAlarma = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpcionesDespertadorActivar = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesDespertadorDesactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextoZona = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zonaAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.zonaSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.ct_Alarma = new P1.EditHora();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.menuContextoAlarma.SuspendLayout();
            this.menuContextoZona.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.OpcionesMenu,
            this.ayudaToolStripMenuItem,
            this.menuZona});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 33);
            this.menuStrip1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.menuStrip1, "Añada/elimine una zona pulsando el botón derecho del ratón");
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
            // OpcionesMenu
            // 
            this.OpcionesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAnalogicoMenu,
            this.toolStripMenuItem2,
            this.colorFondoToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.despertadorToolStripMenuItem});
            this.OpcionesMenu.Name = "OpcionesMenu";
            this.OpcionesMenu.Size = new System.Drawing.Size(103, 29);
            this.OpcionesMenu.Text = "Opciones";
            this.OpcionesMenu.DropDownOpened += new System.EventHandler(this.OpcionesMenu_DropDownOpened);
            // 
            // mostrarAnalogicoMenu
            // 
            this.mostrarAnalogicoMenu.Checked = true;
            this.mostrarAnalogicoMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mostrarAnalogicoMenu.Name = "mostrarAnalogicoMenu";
            this.mostrarAnalogicoMenu.Size = new System.Drawing.Size(261, 34);
            this.mostrarAnalogicoMenu.Text = "Mostrar Analógico";
            this.mostrarAnalogicoMenu.Click += new System.EventHandler(this.mostrarAnalogicoMenu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 6);
            // 
            // colorFondoToolStripMenuItem
            // 
            this.colorFondoToolStripMenuItem.Name = "colorFondoToolStripMenuItem";
            this.colorFondoToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.colorFondoToolStripMenuItem.Text = "Color fondo";
            this.colorFondoToolStripMenuItem.Click += new System.EventHandler(this.colorFondoToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // despertadorToolStripMenuItem
            // 
            this.despertadorToolStripMenuItem.Name = "despertadorToolStripMenuItem";
            this.despertadorToolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.despertadorToolStripMenuItem.Text = "Despertador";
            this.despertadorToolStripMenuItem.DropDownOpening += new System.EventHandler(this.ct_Alarma_DoubleClick);
            this.despertadorToolStripMenuItem.Click += new System.EventHandler(this.ct_Alarma_DoubleClick);
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
            // menuZona
            // 
            this.menuZona.Name = "menuZona";
            this.menuZona.Size = new System.Drawing.Size(76, 29);
            this.menuZona.Text = "Zonas";
            this.menuZona.DropDownOpened += new System.EventHandler(this.menuZona_DropDownOpened);
            this.menuZona.Click += new System.EventHandler(this.menuZona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 1;
            // 
            // ct_HoraActual
            // 
            this.ct_HoraActual.AcceptsReturn = true;
            this.ct_HoraActual.Cursor = System.Windows.Forms.Cursors.Default;
            this.ct_HoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ct_HoraActual.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ct_HoraActual.Location = new System.Drawing.Point(186, 123);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alarma:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(147, 57);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(223, 40);
            this.label.TabIndex = 5;
            this.label.Text = "Hora actual:";
            // 
            // bt_ZonaHoraria_Click
            // 
            this.bt_ZonaHoraria_Click.Location = new System.Drawing.Point(195, 284);
            this.bt_ZonaHoraria_Click.Name = "bt_ZonaHoraria_Click";
            this.bt_ZonaHoraria_Click.Size = new System.Drawing.Size(135, 33);
            this.bt_ZonaHoraria_Click.TabIndex = 6;
            this.bt_ZonaHoraria_Click.Text = "Dialogo Zona";
            this.bt_ZonaHoraria_Click.UseVisualStyleBackColor = true;
            this.bt_ZonaHoraria_Click.Click += new System.EventHandler(this.bt_ZonaHoraria_Click_Click);
            // 
            // menuContextoAlarma
            // 
            this.menuContextoAlarma.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuContextoAlarma.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesDespertadorActivar,
            this.OpcionesDespertadorDesactivar});
            this.menuContextoAlarma.Name = "menuContextoAlarma";
            this.menuContextoAlarma.Size = new System.Drawing.Size(166, 68);
            // 
            // OpcionesDespertadorActivar
            // 
            this.OpcionesDespertadorActivar.Name = "OpcionesDespertadorActivar";
            this.OpcionesDespertadorActivar.Size = new System.Drawing.Size(165, 32);
            this.OpcionesDespertadorActivar.Text = "Activar";
            this.OpcionesDespertadorActivar.Click += new System.EventHandler(this.OpcionesDespertadorActivar_Click);
            // 
            // OpcionesDespertadorDesactivar
            // 
            this.OpcionesDespertadorDesactivar.Enabled = false;
            this.OpcionesDespertadorDesactivar.Name = "OpcionesDespertadorDesactivar";
            this.OpcionesDespertadorDesactivar.Size = new System.Drawing.Size(165, 32);
            this.OpcionesDespertadorDesactivar.Text = "Desactivar";
            this.OpcionesDespertadorDesactivar.Click += new System.EventHandler(this.OpcionesDespertadorDesactivar_Click);
            // 
            // menuContextoZona
            // 
            this.menuContextoZona.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuContextoZona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zonaAñadir,
            this.zonaEliminar,
            this.zonaSeparador});
            this.menuContextoZona.Name = "menuContextoZona";
            this.menuContextoZona.Size = new System.Drawing.Size(147, 74);
            this.menuContextoZona.Opened += new System.EventHandler(this.menuZona_DropDownOpened);
            // 
            // zonaAñadir
            // 
            this.zonaAñadir.Name = "zonaAñadir";
            this.zonaAñadir.Size = new System.Drawing.Size(146, 32);
            this.zonaAñadir.Text = "Añadir";
            this.zonaAñadir.Click += new System.EventHandler(this.zonaAñadir_Click);
            // 
            // zonaEliminar
            // 
            this.zonaEliminar.Enabled = false;
            this.zonaEliminar.Name = "zonaEliminar";
            this.zonaEliminar.Size = new System.Drawing.Size(146, 32);
            this.zonaEliminar.Text = "Eliminar";
            this.zonaEliminar.Click += new System.EventHandler(this.zonaEliminar_Click);
            // 
            // zonaSeparador
            // 
            this.zonaSeparador.Name = "zonaSeparador";
            this.zonaSeparador.Size = new System.Drawing.Size(143, 6);
            this.zonaSeparador.Visible = false;
            // 
            // ct_Alarma
            // 
            this.ct_Alarma.BeepOnError = true;
            this.ct_Alarma.Hora = new System.DateTime(((long)(0)));
            this.ct_Alarma.Location = new System.Drawing.Point(186, 238);
            this.ct_Alarma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ct_Alarma.Mask = "90:00:99";
            this.ct_Alarma.Name = "ct_Alarma";
            this.ct_Alarma.PromptChar = '-';
            this.ct_Alarma.Size = new System.Drawing.Size(148, 26);
            this.ct_Alarma.TabIndex = 3;
            this.ct_Alarma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ct_Alarma.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.ct_Alarma.DoubleClick += new System.EventHandler(this.ct_Alarma_DoubleClick);
            // 
            // RelojDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 368);
            this.Controls.Add(this.bt_ZonaHoraria_Click);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ct_Alarma);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RelojDigital_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuContextoAlarma.ResumeLayout(false);
            this.menuContextoZona.ResumeLayout(false);
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
        private System.Windows.Forms.Button bt_ZonaHoraria_Click;
        private System.Windows.Forms.ToolStripMenuItem despertadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuZona;
        private System.Windows.Forms.ContextMenuStrip menuContextoAlarma;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorActivar;
        private System.Windows.Forms.ToolStripMenuItem OpcionesDespertadorDesactivar;
        private System.Windows.Forms.ContextMenuStrip menuContextoZona;
        private System.Windows.Forms.ToolStripMenuItem zonaAñadir;
        private System.Windows.Forms.ToolStripMenuItem zonaEliminar;
        private System.Windows.Forms.ToolStripSeparator zonaSeparador;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

