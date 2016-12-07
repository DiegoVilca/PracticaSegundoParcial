using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClaseBurbujeoEx2
    {
        public ClaseBurbujeoEx2()
        {
            try
            {
                ClaseBurbujeoEx obj = new ClaseBurbujeoEx();

                obj.MetodoBurbujeo();
            }
            catch (Exception ex)
            {

                throw new Exception("Constructor", ex);
            }
        }

    }
}
