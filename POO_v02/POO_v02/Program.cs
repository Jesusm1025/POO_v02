 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_v02
{
    class Program
    {
    //Crear una aplicación con los siguientes requerimientos.Crear una clase con 
    //el nombre APARTAMENTO, con los atributos: Dirección, Color, área construcción, 
    //Parqueos, Habitaciones y Baños. Declaramos los métodos VENDER y ALQUILAR, en 
    //ellos mostraremos la información de la acción y las características.

    //Los datos deben ser introducidos por el usuario y el objeto debe ser 
    //instanciado desde la clase principal los métodos serán invocados por el 
    //usuario de acuerdo a la acción que desee realizar.
        static void Main(string[] args)
        {
            int opcion;//Variable para menu.
            APARTAMENTO apartamento = new APARTAMENTO();//Declarar objeto.
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Vender.");
                Console.WriteLine("2. Alquilar.");
                Console.WriteLine("3. salir.");
                Console.Write("Accediendo a la opcion: ");
                opcion = int.Parse(Console.ReadLine());
            
                switch (opcion)
                {
                    case 1:
                        apartamento.vender();//Accediendo al metodo vender de la clase apartamento. 
                        break;
                    case 2:
                        apartamento.alquilar();//Accediendo al metodo alquilar de la clase apartamento.
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saliendo");
                        Console.Read();
                        break;
                    default:
                        Console.Write("Introduzca la opcion correcta.");
                        break;
                }
            }
            while (opcion != 3);//Mientras opcion sea diferente a 3, el menu se estara repitiendo.
            Console.ReadKey();
        }
    }
}
