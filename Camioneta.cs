using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    class Camioneta : Vehiculo
    {
        protected string color;

        public string Color
        {
            get { 
                return color; 
                }
            set {
                color = value; 
                }
        }

        public Camioneta() : base ()
        {
            color = "";
        }
        public override string ToString()
        {
            return color + "" + base.ToString();
        }
    }
}
