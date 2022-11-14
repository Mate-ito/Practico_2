using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentadora
{
    class Familiar : VEHICULO
    {
        private int CapacidadDeMaletero;
        public Familiar(string matricula, string marca, string capazidadTanque, string estado, int precioAlquilerDiario, int KmPorLitro, string color, int CapacidadDeMaletero) : base(matricula, marca, capazidadTanque, estado, precioAlquilerDiario, KmPorLitro, color)
        {
            this.CapacidadDeMaletero = CapacidadDeMaletero;
        }
        public int getCapacidadDeMaletero()
        {
            return this.CapacidadDeMaletero;
        }
        public void setCapacidadDeMaletero(int CapacidadDeMaletero)
        {
            this.CapacidadDeMaletero = CapacidadDeMaletero;
        }
    }
}
