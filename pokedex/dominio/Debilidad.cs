using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Debilidad
    {
        private int id;
        private string descripcion;

        public void setId(int id)
        {
            this.id = id;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
