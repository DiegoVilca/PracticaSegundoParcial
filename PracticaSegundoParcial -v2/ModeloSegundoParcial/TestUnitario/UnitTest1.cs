using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {

        Entidades.Tienda miTienda;

        [TestMethod]
        public void ExcepcionTest()
        {
            try
            {
                miTienda = new Entidades.Tienda("Una Direccion", 25, 15);
                miTienda.guardar(miTienda, "C:\\Jamaica\\archivox.xml");
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(Excepciones.NoGuardaException));
                
            }
        }


        [TestMethod]
        public void CreacionArchivoTest()
        {
            Entidades.Tienda auxTienda;
            miTienda = new Entidades.Tienda("direccion test", 12, 6);

            try
            {
                
                miTienda.guardar(miTienda, "TiendaTest.xml");
            }
            catch (Exception)
            {
                
                throw;
            }

            try
            {
                miTienda.leer("TiendaTest.xml", out auxTienda);
            }
            catch (Exception)
            {
                
                throw;
            }

            Assert.AreEqual(auxTienda.Direccion, miTienda.Direccion);
            Assert.AreEqual(auxTienda.AnchoDeFrente, miTienda.AnchoDeFrente);
            Assert.AreEqual(auxTienda.legajo, miTienda.legajo);
        }


    }
}
