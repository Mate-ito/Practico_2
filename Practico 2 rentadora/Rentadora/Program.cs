using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rentadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string Opcion;
            Sucursal sucursal1 = new Sucursal(50,"dirr");
            sucursal1.agrergarAutoDeportivo("aa1123","Toyota","50","Disponible" , 600 , 30 , "Rojo" , 245);
            sucursal1.agrergarAutoUtilitario("xz145", "Toyota", "50", "Disponible", 600, 30, "Rojo", 100);
            sucursal1.agrergarAutoFamiliar("vv1123", "Toyota", "50", "Disponible", 600, 30, "Rojo", 50);

            List<Alquiler> alquileres = new List<Alquiler>();
            Alquiler alq1 = new Alquiler(05552,52543131,"Mateo","Umpierrez",45454888,50000,15, sucursal1.getListaAutos()[0], DateTime.Now);
            Alquiler alq2 = new Alquiler(05481,25966742, "Matias", "Delgado", 459875548, 75000,25, sucursal1.getListaAutos()[2], DateTime.Now);
            alquileres.Add(alq1);
            alquileres.Add(alq2);
            Console.WriteLine("Opciones del sistema: ");
            Console.WriteLine("1)Crear un vehiculo");
            Console.WriteLine("2)Crear un alquiler y detalle");
            Console.WriteLine("3)Buscar alquiler apartir del documento");
            Console.WriteLine("4)Conseguir datos de todos los clientes registrados");
            Console.WriteLine("5)Mostrar los datos y estado de todos los vehiculos registrados");
            Console.WriteLine("6)Calcular el costo de renta de un vehiculo");
            Opcion = Console.ReadLine();
            switch (Opcion)
            {
                case "1":
                    string matricula;
                    string marca;
                    string capacidad;
                    string estado;
                    int precio;
                    int kmLitro;
                    string color;
                    string tipo;
                    Console.WriteLine("Ingrese matricula: ");
                    matricula = Console.ReadLine();
                    Console.WriteLine("Ingrese marca: ");
                    marca = Console.ReadLine();
                    Console.WriteLine("Ingrese capacidad del tanque: ");
                    capacidad = Console.ReadLine();
                    Console.WriteLine("Ingrese estado (disponible o no disponible): ");
                    estado = Console.ReadLine();
                    Console.WriteLine("Ingrese precio de alquiler diario: ");
                    precio = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Kilometro por litro: ");
                    kmLitro = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese color: ");
                    color = Console.ReadLine();
                    Console.WriteLine("Ingrese Tipo de vehiculo 1)Deportivo 2) Familiar 3) Utilitario: ");
                    tipo = Console.ReadLine();
                    if(tipo == "1") 
                    {
                        int velocidad;
                        Console.WriteLine("Ingrese velocidad maxima: ");
                        velocidad = Int32.Parse(Console.ReadLine());
                        sucursal1.agrergarAutoDeportivo(matricula,marca,capacidad,estado,precio,kmLitro,color,velocidad);
                    }
                    else if(tipo == "2") 
                    {
                        int capacidadMaletero;
                        Console.WriteLine("Ingrese capacidad de maletero: ");
                        capacidadMaletero = Int32.Parse(Console.ReadLine());
                        sucursal1.agrergarAutoFamiliar(matricula, marca, capacidad, estado, precio, kmLitro, color, capacidadMaletero);
                    }
                    else 
                    {
                        int capacidadCarga;
                        Console.WriteLine("Ingrese capacidad: ");
                        capacidadCarga = Int32.Parse(Console.ReadLine());
                        sucursal1.agrergarAutoUtilitario(matricula, marca, capacidad, estado, precio, kmLitro, color, capacidadCarga);
                    }
                    sucursal1.getListaAutos()[3].MostrarDatosVehiculo();
                    break;
                case "2":
                    string Nombre;
                    string Apellido;
                    int numero;
                    int documento;
                    int telefono;
                    int precioTotal;
                    int cantidadDias;
                    int Auto;
                    Console.WriteLine("Ingrese Nombre: ");
                    Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Apellido: ");
                    Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese numero: ");
                    numero = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese documento: ");
                    documento = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese telefono: ");
                    telefono = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese precio total: ");
                    precioTotal = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de dias: ");
                    cantidadDias = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese vehiculo: ");
                    Console.WriteLine("1):");
                    sucursal1.getListaAutos()[0].MostrarDatosVehiculo();
                    Console.WriteLine("2):");
                    sucursal1.getListaAutos()[1].MostrarDatosVehiculo();
                    Console.WriteLine("3):");
                    sucursal1.getListaAutos()[2].MostrarDatosVehiculo();
                    Auto = Int32.Parse(Console.ReadLine());
                    Alquiler alq3 = new Alquiler(numero, documento, Nombre, Apellido, telefono, precioTotal, cantidadDias, sucursal1.getListaAutos()[Auto],DateTime.Now);
                    alq3.DatosCliente();
                    alq3.getDetalle().DatosDetalle();
                    break;
                case "3":
                    int documentoABuscar;
                    Console.WriteLine("Ingrese documento: ");
                    documentoABuscar = Int32.Parse(Console.ReadLine());
                    alq1.DocumentoAlquiler(documentoABuscar);
                    alq2.DocumentoAlquiler(documentoABuscar);
                    break;
                case "4":
                    alq1.DatosCliente();
                    alq2.DatosCliente();
                    break;
                case "5":
                    Console.WriteLine("1)");
                    sucursal1.getListaAutos()[0].MostrarDatosVehiculo();
                    Console.WriteLine("2)");
                    sucursal1.getListaAutos()[1].MostrarDatosVehiculo();
                    Console.WriteLine("3)");
                    sucursal1.getListaAutos()[2].MostrarDatosVehiculo();
                    break;
                case "6":
                    string tipoCalc;
                    int Dias;
                    Console.WriteLine("Ingrese cantidad de dias: ");
                    Dias = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese Tipo de vehiculo 1)Deportivo 2) Familiar 3) Utilitario: ");
                    tipoCalc = Console.ReadLine();
                    if (tipoCalc == "1")
                    {
                        sucursal1.getListaAutos()[0].PrecioTotal(Dias);
                    }
                    else if (tipoCalc == "2")
                    {
                        sucursal1.getListaAutos()[2].PrecioTotal(Dias);
                    }
                    else
                    {
                        sucursal1.getListaAutos()[1].PrecioTotal(Dias);
                    }
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }
        }
    }
}
