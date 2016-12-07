using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace Formulario
{
    public partial class Form1 : Form
    {

        Entidades.Tienda miTienda;
        Entidades.Tienda auxTienda;
        Entidades.Tienda auxExtensorTienda1;
        Entidades.Tienda auxExtensorTienda2;
        Entidades.ClaseBurbujeo2 obj;

        public Form1()
        {
            InitializeComponent();

            //---------------------------------------------------------------

            //Burbujeo Hardcodeado

            
            try
            {
                
                obj = new Entidades.ClaseBurbujeo2();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.InnerException.Message + " \nPase por: " + ex.InnerException.Message + "-" + ex.Message + "- Form", "Burbujeo");
            }


            //-------------------------------------------------------------------------------------

            //Extensor de Tienda Hardcodeado



            try
            {
                auxExtensorTienda1 = new Entidades.Tienda("direccion extensor", 8, 14);

                auxExtensorTienda2 = new Entidades.Tienda(auxExtensorTienda1.Direccion, auxExtensorTienda1.CambiarAnchoDeFrente(3), auxExtensorTienda1.legajo);

                //auxExtensorTienda1.CambiarAnchoDeFrente(3); //Si no utilizo Using Entidades no me aparece el metodo extensor

                //Entidades.ExtensorDeTienda.CambiarAnchoDeFrente(auxExtensorTienda, 3); //Mal uso del extensor, no es la finalidad

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Metodo Extensor");
            }



        }



        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {

            try
            {
                miTienda = new Entidades.Tienda(this.txtDireccion.Text, int.Parse(this.txtAncho.Text), int.Parse(this.txtLegajo.Text));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(this.Guardar);

            th1.Start();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Thread th2 = new Thread(this.Leer);

            th2.Start();
        }


        //---------------------------------------------------------------
        private void Guardar()
        {
            if (miTienda.guardar(miTienda, "Tienda.xml"))
            {
                MessageBox.Show("Se ha guardado con exito");
            }
            else { MessageBox.Show("No se pudo guardar"); }

        }

        private void Leer()
        {
            if (miTienda.leer("Tienda.xml", out auxTienda))
            {
                MessageBox.Show("Se leyo con exito");
            }
            else { MessageBox.Show("No se pudo leer"); }
            
        }

        
    }
}
