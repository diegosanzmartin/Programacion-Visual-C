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
    public partial class DlgDatosZona : Form
    {
        private string m_Nombre;
        private TimeSpan m_Diferencia;
        private bool m_Positivo;

        public string Nombre { get; set; }
        public TimeSpan Diferencia { get; set; }
        public bool Positivo { get; set; }

        public DlgDatosZona()
        {
            InitializeComponent();
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            if (ct_Nombre.Text != "")
                this.Nombre = ct_Nombre.Text;
            else
            {
                MessageBox.Show("Introduzca un ciudad válida",
                "Error en los datos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ct_Diferencia.HoraValida)
            {
                DateTime hora = ct_Diferencia.Hora;
                this.Diferencia = new TimeSpan(hora.Hour, hora.Minute, hora.Second);
            }
            else
            {
                MessageBox.Show("Introduzca una diferencia horaria válida",
                "Error en los datos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ct_Diferencia.Focus();
                ct_Diferencia.SelectAll();
                return;
            }
            this.Positivo = bt_Positivo.Checked;
            // Como los datos son válidos el resultado devuelto por el
            // diálogo debe ser OK

            this.DialogResult = DialogResult.OK;
        }

    }
}
