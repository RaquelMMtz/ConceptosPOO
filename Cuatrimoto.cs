using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    class Cuatrimoto : Vehiculo
    {
        protected string  marca;

        public string Marca
        {
            get { 
                return marca; 
            }
            set { 
                marca = value; 
            }
        }

        public Cuatrimoto() : base ()
        {
            marca = "";
        }

        public override string ToString()
        {
            return marca + " " + base.ToString();
        }
    }
}
