using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public static class ExtensionDeTienda
    {
        public static void SetAnchoDeTienda(this Tienda dato, int ancho)
        {
            dato.AnchoDeFrente = ancho;
        }

        //Faltaria aplicarlo en el formulario
    }
}
