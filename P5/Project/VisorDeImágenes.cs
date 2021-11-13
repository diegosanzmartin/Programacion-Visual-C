using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            ActualizarMenús(false);
        }
        private void NuevaHija(string título)
        {
            VentanaHija hija = new VentanaHija(título);
            hija.MdiParent = this;
            hija.PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            hija.AutoScroll = true;
            hija.Show();
        }

        public VentanaHija HijaActiva
        {
            get { return (VentanaHija)this.ActiveMdiChild; }
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

        public void ActualizarMenús(bool opcion)
        {
            if (this.MdiChildren.Length != 1) return;
            ArchivoCerrar.Enabled = opcion;
            VentanaCascada.Enabled = opcion;
            VentanaMosaicoHorizontal.Enabled = opcion;
            VentanaMosaicoVertical.Enabled = opcion;
        }

        //Archivo
        private void ArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArchivoCerrar_Click(object sender, EventArgs e)
        {
            if (this.HijaActiva != null)
                this.HijaActiva.Close();
            
            ActualizarMenús(false);
        }

        private void ArchivoNuevo_Click(object sender, EventArgs e)
        {
            int númeroHijas = this.MdiChildren.Length;
            string título = "Doc" + (númeroHijas + 1);
            NuevaHija(título);
            this.HijaActiva.PictureBox.Image = Properties.Resources.Imágen1;
            ActualizarMenús(true);
        }

        private void ArchivoAbrir_Click(object sender, EventArgs e)
        {
            // Mostrar diálogo OpenFileDialog
            OpenFileDialog dlg = new OpenFileDialog();

            // Mediante la propiedad Filter indicamos el tipo de archivos
            // que se permiten abrir y mediante Title especificamos
            // un título explicativo para la ventana.
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            dlg.Title = dlg.FileName;

            // Si el resultado del diálogo es distinto de OK, terminar.
            if (dlg.ShowDialog() != DialogResult.OK) return;

            byte[] contenidoArchivo = File.ReadAllBytes(dlg.FileName);
            // Creamos un flujo de tipo MemoryStream pasándole el contenido
            // del archivo.
            MemoryStream memoryArchivo = new MemoryStream(contenidoArchivo);

            // Usamos el método FromStream de la clase Image para crear una
            // "imagen" a partir del flujo anterior.
            Image newImage = Image.FromStream(memoryArchivo);
            newImage.Tag = dlg.FileName;

            // Creamos una nueva ventana hija con el método NuevaHija,
            // pasándole como título el nombre del archivo abierto.
            // (dlg.FileName)
            NuevaHija(System.IO.Path.GetFileName(dlg.FileName));

            // Obtenemos una referencia a la nueva ventana mediante la
            // propiedad HijaActiva.
            // Asignamos "imagen" al picture box de la nueva ventana
            HijaActiva.PictureBox.Image = newImage;
            ActualizarMenús(true);
        }
    }
}
