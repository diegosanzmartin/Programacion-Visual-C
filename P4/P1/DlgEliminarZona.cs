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
    public partial class DlgEliminarZona : Form
    {
        public DlgEliminarZona()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }
        List<RelojDigital.ZonaHoraria> m_Zonas = new List<RelojDigital.ZonaHoraria>();
        private int m_ZonaSeleccionada = -1;
        public int ZonaSeleccionada
        {
            get { return m_ZonaSeleccionada; }
        }
        private void DlgEliminarZona_Load(object sender, EventArgs e)
        {
            this.m_Zonas = ((RelojDigital)this.Owner).Zonas;
            foreach (var element in m_Zonas)
            {
                lst_Zonas.Items.Add(element.Nombre);
            }
        }
        private void lst_Zonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lst_Zonas.SelectedItem != null)
            {
                string nombreZona = lst_Zonas.SelectedItem.ToString();  // zona seleccionada

                RelojDigital.ZonaHoraria zonaSeleccionada =
                m_Zonas.Find(
                    delegate (RelojDigital.ZonaHoraria zona) // predicado anónimo
                    {
                        return zona.Nombre == nombreZona;
                    }
                );

                ct_Diferencia.Text = zonaSeleccionada.Diferencia.ToString();
                ct_Signo.Text = zonaSeleccionada.Positivo ? "Positivo" : "Negativo";
            }
        }
        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            m_ZonaSeleccionada = lst_Zonas.SelectedIndex;
            this.DialogResult = DialogResult.OK;
        }
    }
}
