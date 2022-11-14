using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentadora
{
    class DEPORTIVO : VEHICULO
    {
        private int VelocidadMaxima;
        public DEPORTIVO(string matricula, string marca, string capazidadTanque, string estado, int precioAlquilerDiario, int KmPorLitro, string color, int velocidadMaxima): base(matricula,marca, capazidadTanque, estado, precioAlquilerDiario, KmPorLitro, color)
        {
            this.VelocidadMaxima = velocidadMaxima;
        }
        public int getVelocidadMaxima() 
        {
            return this.VelocidadMaxima;
        }
        public void setVelocidadMaxima(int VelocidadMaxima) 
        {
            this.VelocidadMaxima = VelocidadMaxima;
        }
    }
}
