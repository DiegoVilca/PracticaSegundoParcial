using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoGuardarArchivoTest()
        {

            Entidades.Tienda tiendaTest = new Entidades.Tienda("alguna direccion", 20, 15);
            
            try
            {
                
                //Entidades.Tienda tiendaAux;

                tiendaTest.guardar(tiendaTest, "C:\\carpetaFantasma\\tiendaTest.xml"); //guardo en direccion que no existe
                Assert.Fail(); //Si la excepcion que capturo es de tipo assert significa que el metodo guardar paso sin lanzar excepcion
                
            }
            catch (Exception ex)
            {

                Assert.IsInstanceOfType(ex, typeof(Entidades.NoGuardaException));
            }
           
        }

        [TestMethod]
        public void CorrectaCreacionArchivoTest()
        {
            Entidades.Tienda miTienda = new Entidades.Tienda("alguna direccion", 32, 7);
            Entidades.Tienda auxTienda = null;

            try
            {
                miTienda.guardar(miTienda, "tiendaTest.xml");
                miTienda.leer("tiendaTest.xml", out auxTienda);


            }
            catch (Exception)
            {

                Assert.Fail();
            }

            Assert.AreEqual(miTienda.Direccion, auxTienda.Direccion);
            Assert.AreEqual(miTienda.AnchoDeFrente, auxTienda.AnchoDeFrente);
            Assert.AreEqual(miTienda.LegajoPublico, auxTienda.LegajoPublico);

        }


    }
}
