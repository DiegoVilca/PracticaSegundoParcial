using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClaseBurbujeo2
    {
        ClaseBurbujeo1 obj;
        public ClaseBurbujeo2()
        {
            try
            {
                obj = new ClaseBurbujeo1();
                obj.MetodoBurbujeo();

            }
            catch (Exception ex)
            {

                throw new Exception("Constructor", ex);
            }
        }
    }
}
