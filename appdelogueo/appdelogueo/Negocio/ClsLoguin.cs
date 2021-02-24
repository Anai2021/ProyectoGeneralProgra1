using appdelogueo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdelogueo.Negocio
{
    class ClsLoguin
    {
        public Boolean loqueo (ClsDominio Objetodominio) 
        {
            if (Objetodominio.Usuario.Equals("ANAI") && Objetodominio.Passwork.Equals("123"))
            {
                return true;

            }





            return false;

        }



    }
}
