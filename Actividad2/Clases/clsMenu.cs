using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2.Clases
{
    public class clsMenu
    {
        public void ListarOpciones()
        {
            string opcion = "0";
            List<string> Listausuario = new List<string>();
            bool correr = true;

            while (correr)
            {
                Console.Clear();
                Console.WriteLine("  MENU DE OPCIONES:   Digite el numero de la opción deseada:");
                Console.WriteLine(" 1-  INGRESAR");
                Console.WriteLine(" 2-  MOSTRAR LISTA");
                Console.WriteLine(" 3-  ELIMINAR");
                Console.WriteLine(" 4-  BUSCAR");
                Console.WriteLine(" 5-  ORDENAR DE MANERA ASCENDENTE");
                Console.WriteLine(" 6-  ORDENAR DE MANERA DESENDENTE");
                Console.WriteLine(" 0-  SALIR");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                      
                       // Console.Clear();
                       
                        Console.WriteLine("Ingrese los nombres de los Usuarios");
                        string Listado = Console.ReadLine();
                        Listausuario.Add(Listado);
                        Console.WriteLine("Agregado " + Listado);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Su lista de Usuarios es:");
                        foreach (string usuario in Listausuario)
                        {
                          
                            Console.WriteLine(usuario);
                        }
                        Console.ReadKey();
                        break;
                    case "3":

                        Console.WriteLine("Ingrese el Usuario que quiere Eliminar");
                        string removeListado = Console.ReadLine();

                        if (Listausuario.Remove(removeListado))
                        {
                            Console.WriteLine("Eliminado: " + removeListado);
                        } else
                        {
                            Console.WriteLine("Nombre no encontrado: " + removeListado);
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Porfavor ingresa el Usuario que desea Buscar");
                        string buscarUsuario = Console.ReadLine();
                        if (Listausuario.Contains(buscarUsuario))
                        {
                            Console.WriteLine("Usuario Encontrado: " + buscarUsuario);
                        }
                        else
                        {
                            Console.WriteLine("Usuario no Existe: " + buscarUsuario);
                        }
                        Console.ReadKey();
                        break;
                    case "5":

                        Listausuario.Sort();
                        Console.WriteLine("Lista ordenada de manera Ascendente");
                        foreach (var orden in Listausuario)
                        {
                            Console.WriteLine(orden);
                        }
                        Console.ReadKey();
                        break;
                    case "6":

                        Listausuario.Sort();
                        Listausuario.Reverse();
                        Console.WriteLine("Lista ordenada de manera Decendente ");

                        foreach (var desorden in Listausuario)
                        {
                            Console.WriteLine(desorden);
                        }
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Gracias por utilizar nuestros servicios");
                        Console.ReadKey();
                        correr = false;
                        
                        break;
                    default:
                        Console.WriteLine("Ingresaste una Opción no valida, Intenta de nuevo");
                        Console.ReadKey();
                        break;

                }
            } while (opcion != "0");

          
        }
    }
}
