using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaz
{
    public interface IArchivos<T>
    {
        bool guardar(T datos, string archivo);

        bool leer(string archivo, out T dato);
    }
}
