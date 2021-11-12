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
    public partial class VisorImágenes : Form
    {
        public VisorImágenes()
        {
            InitializeComponent();
        }
        private void NuevaHija(string título)
        {
            VentanaHija hija = new VentanaHija(título);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();
        }


        //Ayuda
        private void Ayuda_Click(object sender, EventArgs e)
        {
            Form dlg = new AcercaDe();
            dlg.ShowDialog();
        }

        //Ventana
        private void VentanaCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void VentanaMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void VentanaMosaicoVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //Archivo
        private void ArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArchivoCerrar_Click(object sender, EventArgs e)
        {

        }

        private void ArchivoNuevo_Click(object sender, EventArgs e)
        {
            int númeroHijas = this.MdiChildren.Length;
            string título = "Doc" + (númeroHijas + 1);
            NuevaHija(título);
        }
    }
}
