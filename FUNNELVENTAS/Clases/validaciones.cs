using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNNELVENTAS
{
    class validaciones
    {
        public bool Vacio(string nombre, string contra)
        {
            if (String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(contra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
