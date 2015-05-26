using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionBancaria.Datos
{
    public class Libros : Documentos
    {
        #region "Atributos"
        private int capitulo;
        private int tomos;
        private string nivel;
        #endregion

        #region "Propiedades"
        public int Capitulo
        {
          get { return capitulo; }
          set { capitulo = value; }
        }
        public int Tomos
        {
            get { return tomos; }
            set { tomos = value; }
        }

        private string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        #endregion

        #region "Costructor"
        public Libros()
            :base()
        {
            this.capitulo=0;
            this.tomos = 0;
            this.nivel = "";
        }
        public Libros(string codigo, string titulo, int nAutores, string[] autores, int nIdioma, string[] idioma, string editorial,
            string categoria, int nPaginas, string fEdicion, string fPublicacion, int capitulo, int tomos, string nivel)
            : base(codigo, titulo, nAutores, autores, nIdioma, idioma, editorial,
            categoria, nPaginas, fEdicion, fPublicacion)
        {
            this.capitulo = capitulo;
            this.tomos = tomos;
            this.nivel = nivel;
        }
        #endregion

        #region "Metodos SobreEscritos"
        public override bool Equals(object obj)
        {
            Libros L = (Libros)obj;
            bool result = false;

            if ((this.capitulo == L.capitulo)&&(this.tomos==L.tomos)&&(this.nivel==L.nivel))

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