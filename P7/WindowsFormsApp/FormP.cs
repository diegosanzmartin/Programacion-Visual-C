using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDAvengers;

namespace WindowsFormsApp
{
    public partial class Avengers : Form
    {
        ColCAvengers colAvengers;
        CAvengerBLL bd;
        public Avengers()
        {
            InitializeComponent();
            bd = new CAvengerBLL();
            colAvengers = bd.ObtenerFilasAvengers();
            // Agregar al panel un control ElementoLista por cada objeto CFamosoBO
            foreach (CAvengerBO obj in colAvengers)
            {
                ElementoLista elemento = new ElementoLista();
                elemento.ObjetoVinculado = obj;
                this.flowLayoutPanel.Controls.Add(elemento);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < colAvengers.Count; i++)
            {
                // Actualizar la base de datos con los cambios realizados
                if (colAvengers[i].Modificado)
                {
                    this.bd.ActualizarFamosos(colAvengers[i]);
                }
 }
        }

    }
}
