using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClaseBurbujeo1
    {
        public void MetodoBurbujeo()
        {
            try 
	        {
                Tienda nuevaTienda = new Tienda("direccion burbujeo", 69, 7);
	        }
	        catch (Exception ex)
	        {

                throw new Exception("Metodo de instancia", ex);
	        }
        }

     }
}
