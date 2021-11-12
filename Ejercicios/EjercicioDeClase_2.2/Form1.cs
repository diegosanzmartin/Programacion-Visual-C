using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EjercicioDeClase_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen lápizNegro = new Pen(Color.Black, 2);
            Pen lápizAzul = new Pen(Color.Blue, 2);
            SolidBrush Relleno = new SolidBrush(Color.Yellow);
            g.DrawRectangle(lápizNegro, 10, 150, 150, 150);
            g.DrawLine(lápizAzul, 10, 150, 160, 150);
            g.DrawLine(lápizAzul, 10, 150, 85, 30);
            g.DrawLine(lápizAzul, 85, 30, 160, 150);
            g.FillEllipse(Relleno, 250, 30, 100, 100);
            g.DrawEllipse(Pens.Green, 250, 30, 100, 100);
        }
    }
}
