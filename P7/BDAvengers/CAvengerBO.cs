using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BDAvengers
{
    public class CAvengerBO : INotifyPropertyChanged
    {
        // Propiedades relacionadas con la tabla famoso
        private int ID;
        private string alias, nombre, imagen;
        private DateTime cumple = new DateTime();
        private bool modificado;
        public int Id
        {
            get { return ID; }
            set
            {
                ID = value;
                modificado = true;
                OnPropertyChanged(new PropertyChangedEventArgs("Id"));
            }
        }

        public bool Modificado
        {
            get { return modificado; }
            set { modificado = value; }
        }
        
        public string Alias
        {
            get { return alias; }
            set
            {
                alias = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Alias"));
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Nombre"));
            }
        }
        public string Imagen
        {
            get { return imagen; }
            set
            {
                imagen = value;
                OnPropertyChanged(new PropertyChangedEventArgs("imagen"));
            }
        }
        public string Edad
        {
            get
            {
                DateTime hoy = DateTime.Now;
                int edad = hoy.Year - cumple.Year;
                if (hoy.Month < cumple.Month || (hoy.Month == cumple.Month) && hoy.Day < cumple.Day) --edad;
                return String.Format("{0}", edad);
            }
        }
        public DateTime Cumple
        {
            get { return cumple; }
            set
            {
                cumple = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Cumple"));
            }
        }
        public string NombreAprellidosEdad
        {
            get
            {
                return Alias + ", " + Nombre + " (" + Edad + ")";
            }
        }

        // Constructores
        public CAvengerBO() { }
        public CAvengerBO(int id, string ali, string nom, DateTime cum, string ima = null)
        {
            Id = id; 
            alias = ali; 
            nombre = nom; 
            cumple = cum; 
            imagen = ima;
        }
        // Implementación de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e); // generar evento
            }
        }
    }
}
