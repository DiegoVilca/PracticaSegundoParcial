using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;



namespace Entidades
{
    [XmlInclude(typeof(Local))]
    public class Tienda: Local, IArchivos<Tienda>
    {
        public int legajo;


        protected override int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }


        public Tienda()
        {

        }


        public Tienda(string direccion, int ancho, int legajo) :base(direccion, ancho)
        {
            this.Legajo = legajo;
        }


        public string ExponerDatos()
        {
            return base.ToString();
        }

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

                throw new Excepciones.NoGuardaException("No se guardo", ex);
            }
        }

        public bool leer(string archivo, out Tienda dato)
        {
            try
            {
                using (XmlTextReader lector = new XmlTextReader(archivo))
                {
                    XmlSerializer deserializador = new XmlSerializer(typeof(Tienda));

                    dato = (Tienda)deserializador.Deserialize(lector);

                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.NoLeeException("No leyo", ex);
            }
        }


        //------------------------------------------------
        //Agrego Guardar y Leer txt


        public bool GuardarTXT(string archivo, string dato)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(archivo, true))
                {
                    escritor.WriteLine(dato);

                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.NoGuardaException("No se guardo", ex);
            }

        }

        public bool LeerTXT(string archivo, out string dato)
        {
            //dato = null;

            try
            {
                using (StreamReader lector = new StreamReader(archivo))
                {
                    //while (!lector.EndOfStream)
                    //{
                    //    dato = lector.ReadLine();
                    //}
                    dato = lector.ReadToEnd();

                    return true;
                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.NoLeeException("No se leyo", ex);
            }
        }


        
    }
}
