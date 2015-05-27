using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppGestionEditorial.Modelo;

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

        

        private static List<Formato> Formu = new List<Formato>();
        #endregion

        #region "Propiedades"
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int NAutores
        {
            get { return nAutores; }
            set { nAutores = value; }
        }
        public string[] Autores1
        {
            get { return autores; }
            set { autores = value; }
        }
        public string[] Autores
        {
            get { return autores; }
            set { autores = value; }
        }
        public int NIdioma
        {
            get { return nIdioma; }
            set { nIdioma = value; }
        }
        public int NPaginas
        {
            get { return nPaginas; }
            set { nPaginas = value; }
        }
        public string FEdicion
        {
            get { return fEdicion; }
            set { fEdicion = value; }
        }
        public string FPublicacion
        {
            get { return fPublicacion; }
            set { fPublicacion = value; }
        }
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
        public override string ToString()
        {
            return "Documentos" +
            "\n=============================================" +
            "\nCodigo Del Libro          " + this.codigo +
            "\nTitulo Del Libro          " + this.titulo +
            "\nEditorial Del Libro:      " + this.editorial +
            "\nEdicion Del Libro:        " + this.editorial +
            "\nAutores:                  " + this.autores +
            "\nIdiomas:                  " + this.idioma +
            "\nCategorias:               " + this.categoria +
            "\nNumero De Paginas:        " + this.nPaginas +
            "\nFecha De Edicion:         " + this.fEdicion +
            "\nFecha De Publicacion:     " + this.fPublicacion;
        }

        public override bool Equals(object obj)
        {
            Documentos D = (Documentos)obj;
            bool result = false;
            if ((this.codigo==D.codigo)&&
                (this.titulo==D.titulo)&&
                (this.autores == D.autores)&&
                (this.idioma == D.idioma)&&
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




