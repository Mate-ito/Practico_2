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
        private VEHICULO auto;
        private DateTime fechaDeRetiro;

        public Detalle(int cantidadDeDias, VEHICULO auto, DateTime fechaDeRetiro) 
        {
            this.cantidadDeDias = cantidadDeDias;
            this.auto = auto;
            this.fechaDeRetiro = fechaDeRetiro;
        }

       public int getCantidadDeDias() 
       {
            return cantidadDeDias; 
       }
       public void setCantidadDeDias(int cantidadDeDias) { this.cantidadDeDias = cantidadDeDias;}
       public DateTime getfechaDeRetiro() { return fechaDeRetiro; }
       public void setCfechaDeRetiro(DateTime fechaDeRetiro) { this.fechaDeRetiro = fechaDeRetiro; }
       public void setVehivulo(VEHICULO auto) { this.auto = auto; }
       public VEHICULO getAuto() { return this.auto; }
       public void DatosDetalle() 
       {
            Console.WriteLine("Detalle: ");
            Console.WriteLine("Cantidad de dias: " + cantidadDeDias);
            Console.WriteLine("Fecha de retiro: " + fechaDeRetiro);
            Console.WriteLine("Datos del vehiculo");
            auto.MostrarDatosVehiculo();
       } 
    }
}
