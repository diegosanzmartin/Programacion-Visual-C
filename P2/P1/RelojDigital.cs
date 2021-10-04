using System;
using System.Drawing;
using System.Windows.Forms;

namespace P1
{
    public partial class RelojDigital : Form
    {
        private TimeSpan m_DesfaseHorario = new TimeSpan(0);
        RelojAnalogico m_RelojAnalogico = new RelojAnalogico();

        public RelojDigital()
        {
            InitializeComponent();
            ct_HoraActual.Font = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);
            MostrarHoraActual();
            m_RelojAnalogico.Show(this);
            bt_Mostrar.Text = Properties.Resources.AnalogicoON;
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
        }

        private void bt_Mostrar_Click(object sender, EventArgs e)
        {
            if(m_RelojAnalogico.Focus())
            {
                m_RelojAnalogico.Hide();
                bt_Mostrar.Text = Properties.Resources.AnalogicoOFF;
            }
            else
            {
                m_RelojAnalogico.Show(this);
                bt_Mostrar.Text = Properties.Resources.AnalogicoON;
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
    }
}
