using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentadora
{
    class Detalle
    {
        private int cantidadDeDias;
        private string vehiculo;
        private DateTime fechaDeRetiro;

        public Detalle(int cantidadDeDias, string vehiculo, DateTime fechaDeRetiro) 
        {
            this.cantidadDeDias = cantidadDeDias;
            this.vehiculo = vehiculo;
            this.fechaDeRetiro = fechaDeRetiro;
        }

       public int getCantidadDeDias() { return cantidadDeDias; }
       public void setCantidadDeDias(int cantidadDeDias) { this.cantidadDeDias = cantidadDeDias;}
        public DateTime getfechaDeRetiro() { return fechaDeRetiro; }
        public void setCfechaDeRetiro(DateTime fechaDeRetiro) { this.fechaDeRetiro = fechaDeRetiro; }
    }
}
