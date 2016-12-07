using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Entidades.Tienda miTienda;
        Entidades.Tienda auxTienda;
        Entidades.ClaseBurbujeoEx2 objBurbujeo;

        public Form1()
        {
            InitializeComponent();
            miTienda = new Entidades.Tienda("unaDireccion", 12, 5);
            //this.btnGuardar.Click += new EventHandler(btnGuardar_Click);

            
            try
            {
                objBurbujeo = new Entidades.ClaseBurbujeoEx2();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.InnerException.Message +"\n"+ ex.InnerException.Message +" - "+ ex.Message + "- Form");
            }

        }

        //--------------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(MiGuardador);

            th1.Start();
        }
        //-------------------------------------------------------------------
        private void btnLeer_Click(object sender, EventArgs e)
        {
            Thread th2 = new Thread(MiLector);

            th2.Start();
        }

        private void MiGuardador()
        {

            if (miTienda.guardar(miTienda, "Tienda.xml"))
            {
                MessageBox.Show("La Tienda se ha guardado");
            }
            else 
            {
                MessageBox.Show("La Tienda no se ha guardado");
            }
           
        }

        private void MiLector()
        {
            
            if (miTienda.leer("Tienda.xml", out auxTienda))
            {
                MessageBox.Show("La Tienda ha sido leida");
                MessageBox.Show(auxTienda.ExponerDatos());
            }
            else 
            {
                MessageBox.Show("La Tienda no se pudo leer");
            }
        }
    }
}
