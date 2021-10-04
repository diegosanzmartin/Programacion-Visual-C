using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Ej1_Principal : Form
    {
        private Contraseña m_Contraseña = new Contraseña();

        public Ej1_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_Contraseña.Show(this);
            if (!m_Contraseña.boolContraseña()) this.Close();
        }

        
    }
}
