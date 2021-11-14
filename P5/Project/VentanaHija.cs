using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

        //Ventana
        private void VentanaHija_Resize(object sender, EventArgs e)
        {
            if (this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom)
                this.PictureBox.Size = this.ClientSize;
        }

        //Imagen
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
            ImagenAjustarIco.Checked = this.PictureBox.SizeMode == PictureBoxSizeMode.Zoom;
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
            this.Refresh();
        }

        private void ImagenEscalaGrises_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = this.PictureBox;
            Image imagen = pictureBox.Image;
            using (Graphics gfx = Graphics.FromImage(imagen))
            {
                // Matriz para realizar una transformación al gris
                // manteniendo los valores de luminancia correctos
                ColorMatrix cm = new ColorMatrix(new float[][]{
                    new float[]{0.3f,0.3f,0.3f,0,0},
                    new float[]{0.59f,0.59f,0.59f,0,0},
                    new float[]{0.11f,0.11f,0.11f,0,0},
                    new float[]{0,0,0,1,0},
                    new float[]{0,0,0,0,1}
                });
                // Información acerca de la manipulación de los colores del
                // mapa de bits
                ImageAttributes atrImg = new ImageAttributes();
                atrImg.SetColorMatrix(cm);

                // Dibujar la imagen:
                // DrawImage(Imagen, RectImgDestino, XImgFuente, YImgFuente, anchoImgFuente, anchoImgFuente, UnidadesGráficas, AtributosImagen)
                gfx.DrawImage(imagen, new Rectangle(0, 0, imagen.Width, imagen.Height), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel, atrImg);

            }
            // Refrescar pictureBox
            this.Refresh();
        }

        //Archivo

        private void ArchivoGuardarComo_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void GuardarComo()
        {
            // Mostrar el diálogo SaveFileDialog y configurarlo de forma
            // análoga al OpenFileDialog de la opción "Abrir".
            SaveFileDialog dlgGuardar = new SaveFileDialog();
            dlgGuardar.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            // Si el resultado del diálogo es distinto de OK, terminar.
            if (dlgGuardar.ShowDialog() != DialogResult.OK) return;
            else if (dlgGuardar.FileName.ToUpper().EndsWith(".JPG"))
            {
                // Usar el método Save para guardar la imagen en formato jpg.
                this.PictureBox.Image.Save(dlgGuardar.FileName);
            }
            // Análogamente con el resto de formatos permitidos.
            else if (dlgGuardar.FileName.ToUpper().EndsWith(".PNG"))
                this.PictureBox.Image.Save(dlgGuardar.FileName);
            else if (dlgGuardar.FileName.ToUpper().EndsWith(".BMP"))
                this.PictureBox.Image.Save(dlgGuardar.FileName);
            // Actualizar el título de esta ventana.
            this.Text = System.IO.Path.GetFileName(dlgGuardar.FileName);
            this.PictureBox.Image.Tag = dlgGuardar.FileName;
        }

        private void ArchivoGuardar_Click(object sender, EventArgs e)
        {
            if (this.Text.StartsWith("Doc")) GuardarComo();
            else
                this.PictureBox.Image.Save(this.PictureBox.Image.Tag.ToString());
        }

        private void VentanaHija_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((VisorImágenes)this.MdiParent).ActualizarMenús(false);
        }
    }
}
