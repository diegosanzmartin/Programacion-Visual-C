using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class VentanaHija : Form
    {
        public VentanaHija(string título)
        {
            InitializeComponent();
            this.Text = título;
        }
        public PictureBox PictureBox
        {
            get { return m_PictureBox; }
        }

        private void ImagenAjustar_Click(object sender, EventArgs e)
        {
            // Si no estamos en modo ajustar, activamos este modo
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                this.AutoScroll = false;
                this.PictureBox.Size = this.ClientSize;
                this.PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            // Si estamos en modo ajustar, desactivamos este modo
            else if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
            {
                this.AutoScroll = true;
                this.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            ImagenAjustar.Checked = this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
        }

        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;
        }

        private void ImagenRotar_Click(object sender, EventArgs e)
        {
            this.PictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.PictureBox.Refresh();
        }

        private void ImagenAñadirTexto_Click(object sender, EventArgs e)
        {
            using (Graphics gfx = Graphics.FromImage(this.PictureBox.Image))
            {
                // Utilizar el método DrawString de gfx para pintar el texto
                // "Programación Visual" en la posición 0,0 del área de
                // cliente, utilizando una fuente Arial de 20 ptos
                // y una brocha del color deseado.
                gfx.DrawString("\U0001F427\U0001F427Penguins\U0001F427\U0001F427", new Font("Segoe UI emoji", 20), Brushes.Black, 0, 0, StringFormat.GenericDefault);
            }
            // Refrescar el picture box
            this.PictureBox.Refresh();
        }
    }
}
