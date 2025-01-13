using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2.Clases
{
    public class clsMenu
    {
        public void ListarOpciones()
        {
            string opcion = "0";

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos al Curso Chalo CODE");
                Console.WriteLine("Actividad # 2");
                Console.WriteLine("Presentado por Carlos Ardila");

                Console.WriteLine("------------------------------------------");

                Console.WriteLine("  MENU DE OPCIONES:\n\n Digite el numero de la opción deseada:\n" +
                    "\n 1-  Ingresar" +
                    "\n 2-  Eliminar" +
                    "\n 3-  Buscar" +
                    "\n 4-  Ordenar" +
                    "\n 0-  Salir");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Porfavor Ingrese los valores");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Porfavor eliminar los valores");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Porfavor que valor desea buscar");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("se han ordenado los valores");
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Gracias por utilizar nuestros servicios");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Ingresaste una opcion no valida, Intenta de nuevo");
                        Console.ReadKey();
                        break;

                }
            } while (opcion != "0");
        }
    }
}
