using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class NoLeeException:Exception
    {
        public NoLeeException(string mensaje):this(mensaje, null)
        {

        }

        public NoLeeException(string mensaje, Exception ex) :base(mensaje, ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
