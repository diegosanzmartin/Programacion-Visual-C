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
    public partial class RelojAnalogico : Form
    {
        public RelojAnalogico()
        {
            InitializeComponent();
        }

        private void RelojAnalogico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Focus())
                e.Cancel = true;
        }
    }
}
