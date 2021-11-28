using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAvengers
{
    public class CAvengerBLL
    {
        private CAvengerDAL bd = new CAvengerDAL();
        public ColCAvengers ObtenerFilasAvengers()
        {
            ColCAvengers coTfnos = bd.ObtenerFilasAvengers();
            return coTfnos;
        }
        public void ActualizarFamosos(CAvengerBO bo)
        {
            bd.ActualizarAvengers(bo);
        }
    }
}
