using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class RelojAnalogico : Form
    {
        Point m_Centro = new Point();
        int m_Radio;
        DateTime m_Hora;
        public DateTime Hora
        {
            set
            {
                m_Hora = value;
                Invalidate();
            }
        }

        public RelojAnalogico()
        {
            InitializeComponent();
            ActualizarDimensiones();
        }

        private void ActualizarDimensiones()
        {
            m_Centro.X = this.ClientSize.Width / 2;
            m_Centro.Y = this.ClientSize.Height / 2;
            m_Radio = Math.Min(m_Centro.X, m_Centro.Y);
        }

        private void RelojAnalogico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Focus())
                e.Cancel = true;
        }

        private void RelojAnalogico_Resize(object sender, EventArgs e)
        {
            ActualizarDimensiones();
        }

        private void RelojAnalogico_Paint(object sender, PaintEventArgs e)
        {
            if (m_Radio <= 10)
                return;
            Graphics gfx = e.Graphics;
            Pen lápizMuyGordoAzul = new Pen(Color.Blue, 4);
            float alfa, x, y;

            // Manecilla de las horas
            alfa = (float)((m_Hora.Hour % 12) * Math.PI * 2 / 12);
            alfa += (float)((m_Hora.Minute) * Math.PI * 2 / 12 / 60);
            x = (float)Math.Sin(alfa) * m_Radio;
            y = (float)Math.Cos(alfa) * m_Radio;
            gfx.DrawLine(lápizMuyGordoAzul, m_Centro.X, m_Centro.Y,
            m_Centro.X + (int)(x * .5),
            m_Centro.Y + (int)(y * .5));
            // Manecilla de los minutos
            alfa = (float)((m_Hora.Minute % 60) * Math.PI * 2 / 60);
            alfa += (float)((m_Hora.Second) * Math.PI * 2 / 60 / 60);
            x = (float)(Math.Sin(alfa) * m_Radio);
            y = (float)(Math.Cos(alfa) * m_Radio);
            gfx.DrawLine(lápizMuyGordoAzul, m_Centro.X, m_Centro.Y,
            m_Centro.X + (int)(x * .75),
            m_Centro.Y + (int)(y * .75));
            // Manecilla de los segundos
            alfa = (float)((m_Hora.Second % 60) * Math.PI * 2 / 60);
            x = (float)(Math.Sin(alfa) * m_Radio);
            y = (float)(Math.Cos(alfa) * m_Radio);
            gfx.DrawLine(lápizMuyGordoAzul, m_Centro.X, m_Centro.Y,
            m_Centro.X + (int)(x * .9),
            m_Centro.Y + (int)(y * .9));
        }
    }
}
