using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rentadora
{
    class Alquiler
    {
        private int numero;
        private int documento;
        private string nombre;
        private string apellido;
        private int telefono;
        private int precioTotal;
        private Detalle Detalle1;

        public Alquiler(int numero, int documento, string nombre, string apellido, int telefono,int precioTotal, int cantidadDeDias,VEHICULO autoARentar,DateTime fechaDeRetiro) 
        {
            this.numero = numero;
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.precioTotal = precioTotal;
            this.Detalle1 = new Detalle(cantidadDeDias,autoARentar,fechaDeRetiro);

        }
        public void setDetalle(Detalle Detalle2) { this.Detalle1 = Detalle2; }
        public Detalle getDetalle() { return this.Detalle1; }
        public void setNumero(int numero) { this.numero = numero; }
        public int getNumero() { return this.numero; }
        public void setdocumento(int documento) { this.documento = documento; }
        public int getdocumento() { return this.documento; }
        public void setnombre(string nombre) { this.nombre = nombre; }
        public string getnombre() { return this.nombre; }
        public void setapellido(string apellido) 
        {
            this.apellido = apellido; 
        }
        public string getapellido() { return this.apellido; }
        public void settelefono(int telefono) { this.telefono = telefono; }
        public int gettelefono() { return this.telefono; }
        public void setprecioTotal(int precioTotal) { this.precioTotal = precioTotal; }
        public int getprecioTotal() { return this.precioTotal; }
        public void DatosCliente() 
        {
            Console.WriteLine("Nombre: " + nombre );
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Documento: " + documento);
            Console.WriteLine("Telefono: " + telefono);
        }
        public int CantidadDeDias() 
        {
           return Detalle1.getCantidadDeDias();
        }
        public void DocumentoAlquiler(int DocumentoRecibido) 
        { 
            if(DocumentoRecibido == this.documento) 
            {
                Console.WriteLine("Datos Alquiler: ");
                Console.WriteLine("Cliente: ");
                DatosCliente();
                Console.WriteLine("Auto: ");
                this.Detalle1.getAuto().MostrarDatosVehiculo();
            }
            else 
            {
                Console.WriteLine("Documento no encontrado");
            }
        }
    }
}
