using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Rentadora
{
    class Sucursal
    {
        private int numero;
        private string direccion;
        private List<VEHICULO> listaAutos;

        public Sucursal(int numero, string direccion) 
        {
            this.numero = numero;
            this.direccion = direccion;
            this.listaAutos = new List<VEHICULO>();
           
        }
        public int getNumero() 
        { 
            return this.numero; 
        }
        public void setNumero(int numero) 
        { 
            this.numero = numero; 
        }
        public string getDireccion() 
        { 
            return this.direccion; 
        }
        public void setdireccion(string direccion) 
        { 
            this.direccion = direccion; 
        }

        public void agrergarAutoDeportivo(string Matricula, string Marca,string CapacidadTanque, string Estado ,int precioAlquilerDiario, int KmPorLitro,string color , int velocidadMaxima ) 
        {
            DEPORTIVO autoDeportivo = new DEPORTIVO(Matricula, Marca, CapacidadTanque, Estado, precioAlquilerDiario, KmPorLitro, color, velocidadMaxima);
            listaAutos.Add(autoDeportivo);
        }
        public void agrergarAutoFamiliar(string Matricula, string Marca, string CapacidadTanque, string Estado, int precioAlquilerDiario, int KmPorLitro, string color, int CapacidadMaletero)
        {
            Familiar autoFamiliar = new Familiar(Matricula, Marca, CapacidadTanque, Estado, precioAlquilerDiario, KmPorLitro, color, CapacidadMaletero);
            listaAutos.Add(autoFamiliar);
        }
        public void agrergarAutoUtilitario(string Matricula, string Marca, string CapacidadTanque, string Estado, int precioAlquilerDiario, int KmPorLitro, string color, int Capacidad)
        {
            Utilitario autoUtilitario = new Utilitario(Matricula, Marca, CapacidadTanque, Estado, precioAlquilerDiario, KmPorLitro, color, Capacidad);
            listaAutos.Add(autoUtilitario);
        }
        public List<VEHICULO> getListaAutos() 
        {
            return this.listaAutos;
        }
        public void setListaAutos(List<VEHICULO> listaAutos) 
        {
            this.listaAutos = listaAutos;
        }
    }
}
