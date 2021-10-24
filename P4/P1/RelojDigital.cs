using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Serialización
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace P1
{
    public partial class RelojDigital : Form
    {
        /* RelojDigital */
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
        private void RelojDigital_Shown(object sender, EventArgs e)
        {
            m_RelojAnalogico.Location = new Point(this.Location.X + 360, this.Location.Y);
        }
        private void RelojDigital_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menuContextoZona.Show(Cursor.Position);
            }
        }


        /* RelojAnalógico */
        RelojAnalogico m_RelojAnalogico = new RelojAnalogico();
        private void mostrarAnalogicoMenu_Click(object sender, EventArgs e)
        {
            if (m_RelojAnalogico.Focus())
                m_RelojAnalogico.Hide();
            else
                m_RelojAnalogico.Show(this);
        }

        /* Hora */
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now + m_DesfaseHorario;
            ct_HoraActual.Text = hora.ToLongTimeString();
            m_RelojAnalogico.Hora = hora;
        }
        internal void CambiarHora(int horas, int minutos, int segundos)
        {
            DateTime actual = DateTime.Now;
            DateTime hora = new DateTime(actual.Year, actual.Month, actual.Day, horas, minutos, segundos);
            m_DesfaseHorario = hora - actual;
            Console.WriteLine(hora);
            MostrarHoraActual();
        }


        /* Despertador */
        private bool m_DespertadorActivado = false;
        public bool DespertadorActivado
        {
            get { return m_DespertadorActivado; }
            set
            {
                m_DespertadorActivado = value;

                OpcionesDespertadorActivar.Enabled = !m_DespertadorActivado;
                OpcionesDespertadorDesactivar.Enabled = m_DespertadorActivado;
                cv_Despertador.Checked = m_DespertadorActivado;
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
        private void ct_Alarma_DoubleClick(object sender, EventArgs e)
        {
            menuContextoAlarma.Show(Cursor.Position);
        }
        private void menuContextoAlarma_Opened(object sender, EventArgs e)
        {
            if (m_DespertadorActivado)
            {
                OpcionesDespertadorActivar.Enabled = false;
                OpcionesDespertadorDesactivar.Enabled = true;
            }
            else
            {
                OpcionesDespertadorActivar.Enabled = true;
                OpcionesDespertadorDesactivar.Enabled = false;

            }
        }


        /* Zonas */
        [Serializable()]
        public class ZonaHoraria
        {
            TimeSpan m_Diferencia = new TimeSpan();
            bool m_Positivo = true;
            string m_Nombre = "";

            public string Nombre { get; set; }
            public TimeSpan Diferencia { get; set; }
            public bool Positivo { get; set; }
        }
        private List<ZonaHoraria> m_Zonas = new List<ZonaHoraria>();

        public List<ZonaHoraria> Zonas
        {
            get { return m_Zonas; }
        }
        public int NumeroZonas
        {
            get { return m_Zonas.Count; }
        }
        private void dlgEliminarZonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgEliminarZona dlg = new DlgEliminarZona();
            dlg.ShowDialog();
        }
        private void zonaAñadir_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem zonaNueva = new ToolStripMenuItem();
            DlgDatosZona m_DlgDatosZona = new DlgDatosZona();
            m_DlgDatosZona.Owner = this;
            
            if(m_DlgDatosZona.ShowDialog(this) == DialogResult.OK)
            {
                bool existe = m_Zonas.Exists(
                 delegate (ZonaHoraria zona) // predicado anónimo
                 {
                     return zona.Nombre == m_DlgDatosZona.Nombre;
                 }
                );
                
                if (existe)
                {
                    MessageBox.Show("Ya existe una zona llamada "
                    + m_DlgDatosZona.Nombre);
                    return; // salimos sin modificar nada
                }

                ZonaHoraria zonaListaN = new ZonaHoraria();

                //zonaNueva.Text = "Zona " + (this.NumeroZonas + 1);
                zonaNueva.Text = m_DlgDatosZona.Nombre;
                zonaNueva.Click += zona_Click;
                menuContextoZona.Items.Add(zonaNueva);

                zonaListaN.Nombre = m_DlgDatosZona.Nombre;
                zonaListaN.Diferencia = m_DlgDatosZona.Diferencia;
                zonaListaN.Positivo = m_DlgDatosZona.Positivo;

                Zonas.Add(zonaListaN);
            }
        }
        private void zonaEliminar_Click(object sender, EventArgs e)
        {
            DlgEliminarZona m_DlgEliminarZona = new DlgEliminarZona();
            if (this.NumeroZonas == 0)
            {
                Console.Beep(); // o bien System.Media.SystemSounds.Beep.Play();
                return;
            }
           if(m_DlgEliminarZona.ShowDialog(this) == DialogResult.OK)
            {
                menuContextoZona.Items.RemoveAt(m_DlgEliminarZona.ZonaSeleccionada + 2);
                m_Zonas.RemoveAt(m_DlgEliminarZona.ZonaSeleccionada);
            }
        }
        private void zona_Click(object sender, EventArgs e)
        {
            var zona = (ToolStripMenuItem)sender;
            RelojDigital.ZonaHoraria zonaS = 
            m_Zonas.Find(
                delegate(ZonaHoraria z)
                {
                    return z.Nombre == zona.Text;
                }
            );

            TimeSpan ZonaDiferencia = zonaS.Positivo ? zonaS.Diferencia : -zonaS.Diferencia;
            DateTime ZonaHora = DateTime.Now + ZonaDiferencia;
            
            MessageBox.Show(zona.Text + ": " + ZonaHora.ToString());
        }
        private void menuZona_Click(object sender, EventArgs e)
        {
            menuContextoZona.Show(Cursor.Position);
        }
        private void menuZona_DropDownOpened(object sender, EventArgs e)
        {
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




        ////////////////////////////////////////////////////////////////////////////////

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AcercaDe(object sender, EventArgs e)
        {
            AcercaDe dlg = new AcercaDe();
            dlg.ShowDialog();
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cv_Despertador.Checked)
                m_DespertadorActivado = true;
            else
                m_DespertadorActivado = false;
        }

        private void RelojDigital_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream stream =
                File.Open("reloj.dat", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, m_Zonas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo crear el archivo de zonas. "
                + " Causa: " + ex.Message);
            }
        }
    }
}



