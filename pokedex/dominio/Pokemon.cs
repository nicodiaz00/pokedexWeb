using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        private int id;
        private int numero;
        private string nombre;
        private string descripcion;
        private string urlImagen;
        private Tipo tipo;
        private Debilidad debilidad;

        public void setId(int id)
        {
            this.id = id;
        }

        public void setNumero(int num)
        {
            this.numero = num;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setImagen(string imagen)
        {
            this.urlImagen = imagen;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public int Id
        {
            get { return id; }
        }
        public int Numero
        {
            get { return numero; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Descripcion
        {
            get { return descripcion; }
        }

        public string UrlImagen
        {
            get { return urlImagen; }
        }

        //falta setear tipo y debilidad



    }
}
