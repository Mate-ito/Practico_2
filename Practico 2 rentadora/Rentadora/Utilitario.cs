using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentadora
{
    class Utilitario : VEHICULO
    {
        
        private int CapacidadDeCarga;
        public Utilitario(string matricula, string marca, string capazidadTanque, string estado, int precioAlquilerDiario, int KmPorLitro, string color, int CapacidadDeCarga) : base(matricula, marca, capazidadTanque, estado, precioAlquilerDiario, KmPorLitro, color)
        {
            this.CapacidadDeCarga = CapacidadDeCarga;
        }
        public int getCapacidadDeCarga()
        {
            return this.CapacidadDeCarga;
        }
        public void setCapacidadDeCarga(int VelocidadMaxima)
        {
            this.CapacidadDeCarga = VelocidadMaxima;
        }
    }
}

    

