using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entidades
{
    public class NoGuardaException :Exception
    {
        public NoGuardaException()
        {

        }

        public NoGuardaException(string mensaje) :this(mensaje, null)
        {

        }

        public NoGuardaException(string mensaje, Exception ex) :base(mensaje, ex)
        {
            
        }
    }
}
