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
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
            this.labelAcercaDe.Text = Properties.Resources.textoAcercaDe1;
            this.labelAcercaDe2.Text = Properties.Resources.textoAcercaDe2;
        }
    }
}
