using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDeClase_1
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }

        private int i_pwd = 0;

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {

            if (tb_pwd.Text.CompareTo("Maria123") != 0)
            {
                MessageBox.Show("La palabra de paso no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                i_pwd += 1;
                if (i_pwd == 3)
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
            else
            {

                MessageBox.Show("La palabra de paso es correcta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                
            }
        }
    }
}
