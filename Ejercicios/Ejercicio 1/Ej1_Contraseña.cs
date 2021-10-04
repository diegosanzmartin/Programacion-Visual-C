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
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }
        public bool boolContraseña()
        {
            if (entradaContraseña.TextLength != 9)
            {
                return true;
            }
                return false;
        }
    }
}
