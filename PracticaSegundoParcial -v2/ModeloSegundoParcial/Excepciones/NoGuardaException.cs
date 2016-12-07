using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoGuardaException : Exception
    {
        public NoGuardaException(string mensaje, Exception ex)
        {

        }

        public NoGuardaException(string mensaje) :this(mensaje, null)
        {

        }

        public NoGuardaException(Exception ex) :this(null, ex)
        {

        }
    }
}
