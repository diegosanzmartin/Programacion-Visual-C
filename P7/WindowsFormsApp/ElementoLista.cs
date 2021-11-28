using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDAvengers;

namespace WindowsFormsApp
{
    public partial class ElementoLista : UserControl
    {
        public ElementoLista()
        {
            InitializeComponent();
            // Obtener el enlace con la propiedad Image del control imgFamoso
            // para gestionar su evento Format
            Binding bImagen = this.imgAvenger.DataBindings["Image"];
            bImagen.Format += this.StringToBitmap;
            this.imgAvenger.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void StringToBitmap(object sender, ConvertEventArgs e)
        {
            // Format ocurre siempre que haya que mostrar en imgFamoso
            // el valor de la propiedad Imagen (la ruta de la imagen)
            if (e.DesiredType != typeof(Image)) return;
            // Convertir la ruta de la imagen a un Bitmap
            e.Value = Bitmap.FromFile(ObtenerRutaImagen(e.Value as string));
        }

        public CAvengerBO ObjetoVinculado
        {
            get { return this.avengerBindingSource.DataSource as CAvengerBO; }
            set
            {
                // Vincular objeto
                this.avengerBindingSource.DataSource = value;
                // Establecer un tooltip en la imagen que muestre el ID correspondiente
                // al objeto CFamosoBO
                if (value != null)
                {
                   string msj = "ID famoso: " + value.Id;
                   this.ttElementoLista.SetToolTip(this.imgAvenger, msj);
                }
            }
        }

        private string ObtenerRutaImagen(string nombreImagen)
        {
            string carpeta = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            carpeta = Path.Combine(carpeta, "Imagenes");
            return Path.Combine(carpeta, nombreImagen);
        }
    }
}
