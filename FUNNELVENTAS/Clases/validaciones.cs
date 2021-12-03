using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using FUNNELVENTAS.Clases;
using System.Threading.Tasks;

namespace FUNNELVENTAS
{
   public class validaciones
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
