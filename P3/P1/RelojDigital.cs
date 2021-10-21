using System;
using System.Drawing;
using System.Windows.Forms;


namespace P1
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        RelojAnalogico m_RelojAnalogico = new RelojAnalogico();
        private bool m_DespertadorActivado = false;
        private const int MaxZonas = 4;
        public bool DespertadorActivado
        {
            get { return m_DespertadorActivado; }
            set
            {
                m_DespertadorActivado = value;

                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;
            }

        }

        public int NumeroZonas
        {
            get { return menuContextoZona.Items.Count - 3; }
        }


        public RelojDigital()
        {
            InitializeComponent();
            ct_HoraActual.Font = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            ct_HoraActual.BackColor = Color.White;
            ct_HoraActual.ForeColor = Color.Blue;
            MostrarHoraActual();
            m_RelojAnalogico.Show(this);
            mostrarAnalogicoMenu.CheckState = CheckState.Checked;
            this.toolTip1.SetToolTip(this.menuStrip1, Properties.Resources.mensajeBarraMenus);
        }

        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToLongTimeString();
            m_RelojAnalogico.Hora = hora;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercaDe(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe();
            dlg.ShowDialog();
        }

        private void bt_Actualizar_Click(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            MostrarHoraActual();
        }
        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            m_RelojAnalogico.Location = new Point(this.Location.X + 100 + 10, 1000);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MostrarHoraActual();

            if (!m_DespertadorActivado)
                return;

            if (!ct_Alarma.HoraValida)
            {
                System.Diagnostics.Debug.WriteLine("Hora alarma nó válida");
                return;
            }
            DateTime horaActual = DateTime.Now + m_DesfaseHorario;
            DateTime horaAlarma = ct_Alarma.Hora;
            int segundosActual = horaActual.Second + horaActual.Minute * 60 + horaActual.Hour * 3600;
            // Segundos alarma:
            int segundosAlarma = horaAlarma.Second + horaAlarma.Minute * 60 + horaAlarma.Hour * 3600;

            //System.Diagnostics.Debug.WriteLine(segundosActual + " " + segundosAlarma);
            if (segundosActual >= segundosAlarma)
            {
                if (segundosActual - segundosAlarma < 300)
                {
                    Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                }
            }
            else if (segundosAlarma - segundosActual > 86400 - 300)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
            }
        }

        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            DateTime actual = DateTime.Now;
            DateTime hora = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);
            m_DesfaseHorario = hora - actual;
            Console.WriteLine(hora);
            MostrarHoraActual();
        }

        private void mostrarAnalogicoMenu_Click(object sender, EventArgs e)
        {
            if (m_RelojAnalogico.Focus())
                m_RelojAnalogico.Hide();
            else
                m_RelojAnalogico.Show(this);
        }

        private void OpcionesMenu_DropDownOpened(object sender, EventArgs e)
        {
            if (!m_RelojAnalogico.Focus())
                mostrarAnalogicoMenu.CheckState = CheckState.Unchecked;
            else
                mostrarAnalogicoMenu.CheckState = CheckState.Checked;
        }

        private void colorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColor = new ColorDialog();
            //... Inicialización del diálogo
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                // ... Extracción de los datos introducidos por el usuario
                ct_HoraActual.BackColor = dlgColor.Color;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            //... Inicialización del diálogo
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                // ... Extracción de los datos introducidos por el usuario
                ct_HoraActual.Font = dlgFont.Font;
            }
        }

        private void bt_ZonaHoraria_Click_Click(object sender, EventArgs e)
        {
            DlgDatosZona dlg = new DlgDatosZona();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string desfase = dlg.Diferencia.ToString();
                string signo = dlg.Positivo ? "Positivo" : "Negativo";

                // Visualizar una caja de diálogo que muestre los datos
                // de la zona recogidos en el diálogo
                MessageBox.Show("Nombre: " + dlg.Nombre + "\nDesfase: " + desfase + "\nSigno: " + signo, "Datos de la zona",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
        }

        private void OpcionesDespertadorActivar_Click(object sender, EventArgs e)
        {
            m_DespertadorActivado = true;
            OpcionesDespertadorActivar.Enabled = false;
            OpcionesDespertadorDesactivar.Enabled = true;
        }

        private void OpcionesDespertadorDesactivar_Click(object sender, EventArgs e)
        {
            m_DespertadorActivado = false;
            OpcionesDespertadorActivar.Enabled = true;
            OpcionesDespertadorDesactivar.Enabled = false;
        }

        private void menuZona_DropDownOpened(object sender, EventArgs e)
        {
            if (NumeroZonas == MaxZonas)
                zonaAñadir.Enabled = false;
            else
                zonaAñadir.Enabled = true;

            if (NumeroZonas == 0)
            {
                zonaEliminar.Enabled = false;
                zonaSeparador.Visible = false;
            }
            else
            {
                zonaEliminar.Enabled = true;
                zonaSeparador.Visible = true;
            }
        }

        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("zona nueva");
            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
            zonaNueva.Text = "Zona " + (this.NumeroZonas + 1);
            // Especifique el manejador del evento Click de zonaNueva; la
            // respuesta a este evento vendrá dada por el método zona_Click.
            // Añada el elemento zonaNueva al menú menúZona.
            if (this.NumeroZonas == MaxZonas)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                return;
            }

            zonaNueva.Click += zona_Click;
            menuContextoZona.Items.Add(zonaNueva);
            
        }
        private void zona_Click(object sender, EventArgs e)
        {
            var zona = (ToolStripMenuItem)sender;
            MessageBox.Show(zona.Text);
        }

        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            if (this.NumeroZonas == 0)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                return;
            }
            menuContextoZona.Items.RemoveAt(NumeroZonas+2);
        }

        private void ct_Alarma_DoubleClick(object sender, EventArgs e)
        {
            menuContextoAlarma.Show(Cursor.Position);
        }

        private void menuZona_Click(object sender, EventArgs e)
        {
            menuContextoZona.Show(Cursor.Position);
        }

        private void RelojDigital_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuContextoZona.Show(Cursor.Position);
            }
        }
    }
}


