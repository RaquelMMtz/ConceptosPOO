using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    class Vehiculo 
    {
        protected int modelo;

        public int Modelo
        {
            get { 
            return modelo; 
                 }
            set
        { 
        modelo = value; 
        }
        }
        public Vehiculo ()
        {
            modelo  =  0;
        }
        public override string ToString()
        {
            return modelo + "";
        }
    }
}
