using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoLeeException :Exception
    {
        public NoLeeException(string mensaje, Exception ex) :base(mensaje, ex)
        {

        }

        public NoLeeException(Exception ex) :this(null, ex)
        {

        }
    }
}
