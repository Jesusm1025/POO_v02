using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_v02
{
    class APARTAMENTO
    {
        //Crear una aplicación con los siguientes requerimientos.Crear una clase con 
        //el nombre APARTAMENTO, con los atributos: Dirección, Color, área construcción, 
        //Parqueos, Habitaciones y Baños.Declaramos los métodos VENDER y ALQUILAR, en 
        //ellos mostraremos la información de la acción y las características.

        //Agregando los atributos de la clase.
        public string Direccion;
        public string Color;
        public string Area_Construccion;
        public int Parqueo;
        public int Habitaciones;
        public int Baños;

        public APARTAMENTO()//Ingresando los datos por consola.
        {
            Console.Write("Introduzca la dirreccion: ");
            Direccion = Console.ReadLine();
            Console.Write("Introduzca el color: ");
            Color = Console.ReadLine();
            Console.Write("Introduzca el area de construccion: ");
            Area_Construccion = Console.ReadLine();
            Console.Write("Introduzca la cantidad de parqueos: ");
            Parqueo = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la cantidad de habitaciones: ");
            Habitaciones = int.Parse(Console.ReadLine());
            Console.Write("Introduzca la cantidad de baños: ");
            Baños = int.Parse(Console.ReadLine()); 
        }
        public void vender()//Metodo vender.
        {
            Console.Clear();
            Console.WriteLine("Venta de apartamento.");
            Console.WriteLine("Dirrecion: " + Direccion);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Area de construccion: " + Area_Construccion);
            Console.WriteLine("Parqueos: " + Parqueo);
            Console.WriteLine("Habitaciones: " + Habitaciones);
            Console.WriteLine("Baños: " + Baños);
            Console.ReadKey();
            Console.Clear();
            Console.Write("Volviendo al menu.");
            Console.ReadKey();
        }
        public void alquilar()//Metodo alquilar.
        {
            Console.Clear();
            Console.WriteLine("Alquiler de apartamento.");
            Console.WriteLine("Dirrecion: " + Direccion);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Area de construccion: " + Area_Construccion);
            Console.WriteLine("Parqueos: " + Parqueo);
            Console.WriteLine("Habitaciones: " + Habitaciones);
            Console.WriteLine("Baños: " + Baños);
            Console.ReadKey();
            Console.Clear();
            Console.Write("Volviendo al menu.");
            Console.ReadKey();
        }

    }
}
