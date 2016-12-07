using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public static class ExtensorDeTienda
    {
        public static int CambiarAnchoDeFrente (this Tienda obj, int entero)
        {
             return obj.AnchoDeFrente = entero;

        }
    }
}
