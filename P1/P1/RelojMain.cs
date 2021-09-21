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
    public partial class RelojDigital : Form
    {
        public RelojDigital()
        {
            InitializeComponent();
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
    }
}
