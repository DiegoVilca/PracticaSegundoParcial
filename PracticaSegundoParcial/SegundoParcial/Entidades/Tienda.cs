using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization; 

namespace Entidades
{
    [XmlInclude(typeof(Local))]
    public class Tienda : Local, IArchivos<Tienda>
    {
        private int _legajo;
        protected override int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public int LegajoPublico
        {
            get
            {
                return this.Legajo;
            }
            set
            {
                this.Legajo = value;
            }
        }

        public Tienda()
        {

        }

        public Tienda(string direccion, int anchoDeFrente, int legajo) :base(direccion, anchoDeFrente)
        {
            this.Legajo = legajo;
        }


        //interface
        public bool guardar(Tienda datos, string archivo)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Tienda));

                    serializador.Serialize(escritor, datos);

                    return true;

                }
            }
            catch (Exception ex)
            {

                throw new NoGuardaException("No se ha podido guardar: "+ ex.Message);
            }
        }

        public bool leer(string archivo, out Tienda datos)
        {
            try
            {
                using (XmlTextReader lector = new XmlTextReader(archivo))
                {
                    XmlSerializer deserializador = new XmlSerializer(typeof(Tienda));

                    datos = (Tienda)deserializador.Deserialize(lector);

                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new NoLeeException("No se ha podido leer: " + ex.Message);
            }
        }

        public string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            

            return sb.ToString();
        }
    }
}
