using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormEventos
{
    public partial class Form1 : Form
    {
        Entidades.miClase obj;

        public Form1()
        {
            InitializeComponent();

            obj = new Entidades.miClase();

            obj.SaldoNegativo += obj_SaldoNegativo; //(+= TabTab) Suscribo el metodo obj_SaldoNegativo al evento
            
        }

        void obj_SaldoNegativo(int monto) //Metodo que ocurre al ejecutarse el evento
        {
            MessageBox.Show("No hay suficiente saldo para retirar $"+monto.ToString());
        }

        private void btbRetirar_Click(object sender, EventArgs e)
        {
            obj.saldo = int.Parse(this.txtSaldo.Text);
            obj.SacarDinero(int.Parse(this.txtMonto.Text)); //Ejecuto el metodo que dispara el evento

            
        }
    }
}
