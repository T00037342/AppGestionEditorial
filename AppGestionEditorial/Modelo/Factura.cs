using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppGestionEditorial.Modelo;

namespace AppGestionEditorial.Modelo
{
    public class Factura
    {
        #region "Atributos"
        private int id;
        private string fecha;

        private static List<Documentos> Formu = new List<Documentos>();
        #endregion

        #region "Propiedades"
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        #endregion

        #region "Costructor"
        public Factura() 
        {
            this.id = 0000;
            this.fecha = "";
        }
        public Factura(int id, string fecha) 
        {
            this.id = id;
            this.fecha = fecha;
        }
        #endregion

        #region "Metodos SobreEscritos"
        public override string ToString()
        {
            return "Documentos" +
            "\n=============================================" +
            "\nID:               " + this.id +
            "\nFecha:            " + this.fecha;
        }

        public override bool Equals(object obj)
        {
            Factura F = (Factura)obj;
            bool result = false;
            if ((this.id==F.id)&&
                (this.fecha==F.fecha))

                result = true;

            return result;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion 
    }
}