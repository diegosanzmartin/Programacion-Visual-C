using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    class EditHora : MaskedTextBox
    {
        public EditHora()
        {
            this.Mask = "90:00:99";
            this.TextAlign = HorizontalAlignment.Center;
            this.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            this.BeepOnError = true;
            this.PromptChar = '-';
        }
        private DateTime m_Hora;

        public DateTime Hora
        {
            get { return m_Hora; }
            set { m_Hora = value; }
        }
        public bool HoraValida
        {
            get
            {
                if (!this.MaskCompleted)
                    return false;
                string aux = this.Text.Replace(this.PromptChar, '0');
                DateTime hora = new DateTime();
                if (!DateTime.TryParse(aux, out hora))
                    return false; // hora no correcta

                this.Hora = hora;
                return true; // hora correcta
            }
        }
    }
}
