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
            MostrarHoraActual();
            m_RelojAnalogico.Show(this);
        }

        private void MostrarHoraActual()
        {
            DateTime hora = DateTime.Now;
            ct_HoraActual.Text = hora.ToLongTimeString();
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
    }
}
