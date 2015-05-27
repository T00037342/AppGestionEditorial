using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionBancaria.Datos
{
    public class Revistas : Documentos
    {
        #region "Atributos"
        private int articulos;
        private int volumen;
        #endregion
        
        #region "Propiedades"
        public int Volumen
        {
            get { return volumen; }
            set { articulos = value; }
        }
        public int Articulos
        {
          get { return articulos; }
          set { articulos = value; }
        }
        #endregion

        #region "Costructor"
        public Revistas()
            : base()
        {
            this.volumen = 0;
            this.articulos = 0;
        }
        public Revistas(string codigo, string titulo, int nAutores, string[] autores, int nIdioma, string[] idioma, string editorial,
            string categoria,int nPaginas,string fEdicion,string fPublicacion,int articulos,int volumen) 
            : base( codigo,titulo, nAutores, autores, nIdioma, idioma, editorial,
            categoria, nPaginas, fEdicion, fPublicacion)
        {
            this.volumen = volumen;
            this.articulos = articulos;
        }
        #endregion

        #region "Metodos SobreEscritos"

        public override string ToString()
        {
            return 
            "=================================================" +
            "\nNumero de articulos:      " + this.articulos +
            "\nNumero de Volumen:        " + this.volumen;
        }

        public override bool Equals(object obj)
        {
            Revistas R = (Revistas)obj;
            bool result = false;

            if ((this.articulos == R.articulos)&&(this.volumen==R.volumen))

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