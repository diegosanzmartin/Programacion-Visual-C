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
    }
}
