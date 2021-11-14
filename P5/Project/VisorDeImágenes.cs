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

        private void VisorImágenes_DragEnter(object sender, DragEventArgs e)
        {
            // Nos aseguramos de que lo que se está arrastrando son archivos
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!file.ToUpper().EndsWith(".JPG") &&
                !file.ToUpper().EndsWith(".BMP") &&
                !file.ToUpper().EndsWith(".GIF"))
                {
                    e.Effect = DragDropEffects.None; // Alguno de los archivos
                                                     // no es una imagen
                    return;
                }
            }
            e.Effect = DragDropEffects.Copy; // Correcto, son todo imágenes
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

            // Si el resultado del diálogo es distinto de OK, terminar.
            if (dlg.ShowDialog() != DialogResult.OK) return;
            string path = dlg.FileName;

            AbrirArchivo(path);
        }

        private void AbrirArchivo(string path)
        {
            string name = System.IO.Path.GetFileName(path);
            byte[] contenidoArchivo = File.ReadAllBytes(path);
            // Creamos un flujo de tipo MemoryStream pasándole el contenido
            // del archivo.
            MemoryStream memoryArchivo = new MemoryStream(contenidoArchivo);

            // Usamos el método FromStream de la clase Image para crear una
            // "imagen" a partir del flujo anterior.
            Image newImage = Image.FromStream(memoryArchivo);
            newImage.Tag = path;

            // Creamos una nueva ventana hija con el método NuevaHija,
            // pasándole como título el nombre del archivo abierto.
            // (dlg.FileName)
            NuevaHija(name);

            // Obtenemos una referencia a la nueva ventana mediante la
            // propiedad HijaActiva.
            // Asignamos "imagen" al picture box de la nueva ventana
            HijaActiva.PictureBox.Image = newImage;
            ActualizarMenús(true);
        }

        private void VisorImágenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                AbrirArchivo(file);
        }

        private void VisorImágenes_MdiChildActivate(object sender, EventArgs e)
        {
            //Eliminar cualquier fusión previa
            ToolStripManager.RevertMerge(this.MenúHerramientas);
            VentanaHija ventanaHijaActiva = (VentanaHija)this.ActiveMdiChild;

            if (ventanaHijaActiva != null)
                ToolStripManager.Merge(ventanaHijaActiva.MenúHerramientasHijo, this.MenúHerramientas);
        }

        //Estado etiquetas
        private void ArchivoNuevoIco_MouseEnter(object sender, EventArgs e)
        {
            this.etiquetaEstado.Text = "Crea una nueva ventana con una imagen predefinida";
        }

        private void ArchivoNuevoIco_MouseLeave(object sender, EventArgs e)
        {
            this.etiquetaEstado.Text = "";
        }
    }
}
