using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public delegate void MiDelegado(int monto);
    public class miClase
    {

        public int saldo;


        public void SacarDinero(int monto)
        {

            if (monto > saldo)
            {
                SaldoNegativo(monto);
            }
        }

        public event MiDelegado SaldoNegativo;
        

    }
}
