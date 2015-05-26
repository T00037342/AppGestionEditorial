using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionBancaria.Datos
{
    public class Cientificos : Documentos
    {
        #region "Atributos"
        private string tipo;
        #endregion

        #region "Propiedades"
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        #endregion

        #region "Costructor"
        public Cientificos()
            : base()
        {
            this.tipo = "";
        }
        public Cientificos(string codigo,string titulo,int nAutores,string[] autores,int nIdioma,string[] idioma,string editorial,
            string categoria,int nPaginas,string fEdicion,string fPublicacion,string tipo) 
            : base( codigo,titulo, nAutores, autores, nIdioma, idioma, editorial,
            categoria, nPaginas, fEdicion, fPublicacion)
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Metodos SobreEscritos"
        public override bool Equals(object obj)
        {
            Cientificos C = (Cientificos)obj;
            bool result = false;

            if (this.tipo == C.tipo)

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