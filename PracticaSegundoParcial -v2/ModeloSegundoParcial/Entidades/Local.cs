using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class Local
    {
        private string _direccion;

        private int _anchoDeFrente;
        

        #region xml

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public int AnchoDeFrente
        {
            get { return _anchoDeFrente; }
            set { _anchoDeFrente = value; }
        }

        public Local()
        {

        }

        #endregion

        public Local(string direccion, int ancho)
        {
            if (ancho < 0 || ancho % 2 != 0)
            {
                throw new Exception("Ancho negativo o impar");
            }else
            {
                this._direccion = direccion;
                this._anchoDeFrente = ancho;
            }
            
            
        }

        protected abstract int Legajo
        { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("direccion: "+this._direccion);
            sb.AppendLine("ancho de frente: "+ this._anchoDeFrente);
            sb.AppendLine("legajo: "+this.Legajo);

            return sb.ToString();
        }
    }
}
