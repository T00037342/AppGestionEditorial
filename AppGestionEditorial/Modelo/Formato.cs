using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Formato
    {
        #region "Atributos"
        private int codigo;
        private string nombre;
        private bool iPermisos;
        private bool leer;
        private bool guardar;
        private bool imprimir;
        private bool editar;
        private bool escuchar;
        private bool visualisar;
        #endregion

        #region "Propiedades"
        public int Codigo
        {
            get{return codigo; }
            set{ codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public bool IPermisos
        {
          get { return iPermisos; }
          set { iPermisos = value; }
        }
        public bool Leer
        {
          get { return leer; }
          set { leer = value; }
        }
        public bool Guardar
        {
          get { return guardar; }
          set { guardar = value; }
        }
        public bool Imprimir
        {
          get { return imprimir; }
          set { imprimir = value; }
        }
        public bool Editar
        {
            get { return editar; }
            set { editar = value; }
        }
        public bool Escuchar
        {
            get { return escuchar; }
            set { escuchar = value; }
        }
        public bool Visualisar
        {
            get { return visualisar; }
            set { visualisar = value; }
        }

        #endregion

        #region "Codstructor"
        public Formato()
        {
            this.codigo = 000;
            this.nombre = "";
        }
        public Formato(int codigo,string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }
        
        #endregion

        #region "Metodos SobreEscritos"
        public override bool Equals(object obj)
        {
            Formato D = (Formato)obj;
            bool result = false;
            if ((this.codigo == D.codigo) &&
                (this.nombre == D.nombre))

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