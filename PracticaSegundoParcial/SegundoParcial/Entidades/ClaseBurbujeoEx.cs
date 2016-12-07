using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClaseBurbujeoEx
    {

       
        public void MetodoBurbujeo()
        {
            
            try
            {
                Tienda miTienda = new Tienda("soy una direccion", -42, 11);
            }
            catch (Exception ex)
            {

                throw new Exception("Metodo", ex);
            }


        }
    }
}
