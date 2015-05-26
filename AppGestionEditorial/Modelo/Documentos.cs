using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionBancaria.Datos
{
    public class Documentos
    {
        #region "Atributos"
        private string codigo;
        private string titulo;
private string editorial;
        private string categoria;
        private int nAutores;
        private string[] autores;
        private int nIdioma;
        private string[] idioma;

        
        private int nPaginas;
        private string fEdicion;
        private string fPublicacion;

        //private static List<Formato> = new List<Formato>;
        #endregion

        #region "Propiedades"
        
        #endregion

        #region "Costructor"
        public Documentos() 
        {
            this.codigo="";
            this.titulo="";
            this.nAutores = 0;
            this.nIdioma=0;
            this.editorial = "";
            this.categoria = "";
            this.nPaginas=0;
            this.fEdicion="";
            this.fPublicacion="";
        }
        public Documentos(string codigo,string titulo,int nAutores,string[] autores,int nIdioma,string[] idioma,string editorial,
            string categoria,int nPaginas,string fEdicion,string fPublicacion) 
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.nAutores = nAutores;
            this.nIdioma = nIdioma;
            this.editorial = editorial;
            this.categoria = categoria;
            this.nPaginas = nPaginas;
            this.fEdicion = fEdicion;
            this.fPublicacion = fPublicacion;

            for (int i = 0; i < this.nAutores; i++)
            {
                this.autores[i] = autores[i];
            }

            for (int f = 0; f < this.nIdioma; f++)
            {
                this.idioma[f] = idioma[f];
            }
        }
        #endregion

        #region "Metodos SobreEscritos"
        public override bool Equals(object obj)
        {
            Documentos D = (Documentos)obj;
            bool result = false;
            if ((this.codigo==D.codigo)&&
                (this.titulo==D.titulo)&&
                (this.nAutores == D.nAutores)&&
                (this.nIdioma == D.nIdioma)&&
                (this.editorial == D.editorial)&&
                (this.categoria == D.categoria)&&
                (this.nPaginas == D.nPaginas)&&
                (this.fEdicion == D.fEdicion)&&
                (this.fPublicacion == D.fPublicacion))

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




