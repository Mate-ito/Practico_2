using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentadora
{
    class VEHICULO
    {
        private string matricula;
        private string marca;
        private string capazidadTanque;
        private string estado;
        private int precioAlquilerDiario;
        private int KmPorLitro;
        private string color;

        public VEHICULO(string matricula,string marca, string capazidadTanque, string estado, int precioAlquilerDiario , int KmPorLitro, string color )
        {
            this.matricula = matricula;
            this.marca = marca;
            this.capazidadTanque = capazidadTanque;
            this.estado = estado;
            this.precioAlquilerDiario = precioAlquilerDiario;
            this.KmPorLitro = KmPorLitro;
            this.color = color;
        }

        //Getter y Setter
        public string getMatricula()
        {
            return this.matricula;
        }
        public void setMatricula(string matricula) 
        {
            this.matricula = matricula;
        }
        public string getmarca()
        {
            return this.marca;
        }
        public void setmarca(string marca)
        {
            this.marca = marca;
        }
        public string getcapazidadTanque()
        {
            return this.capazidadTanque;
        }
        public void setcapazidadTanque(string capazidadTanque)
        {
            this.capazidadTanque = capazidadTanque;
        }
        public string getestado()
        {
            return this.estado;
        }
        public void setestado(string estado)
        {
            this.estado = estado;
        }
        public string getcolor()
        {
            return this.color;
        }
        public void setcolor(string color)
        {
            this.color = color;
        }
        public int getprecioAlquilerDiario()
        {
            return this.precioAlquilerDiario;
        }
        public void setprecioAlquilerDiario(int precioAlquilerDiario)
        {
            this.precioAlquilerDiario = precioAlquilerDiario;
        }
        public int getKmPorLitro()
        {
            return this.KmPorLitro;
        }
        public void setKmPorLitro(int KmPorLitro)
        {
            this.KmPorLitro = KmPorLitro;
        }
        public int PrecioTotal(int CantidadDias) 
        {
            int CostoTotal = 0;
            CostoTotal = precioAlquilerDiario * CantidadDias;

            return CostoTotal;
        }
        public void MostrarDatosVehiculo() 
        {
            Console.WriteLine("Matricula: " + matricula);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("CapazidadTanque: " + capazidadTanque);
            Console.WriteLine("Estado: " + estado);
            Console.WriteLine("Precio de alquiler diario: " + precioAlquilerDiario);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Km por litro: " + KmPorLitro);
            Console.WriteLine("Color: " + color);
        }
    }
}
