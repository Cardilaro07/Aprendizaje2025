using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    internal class clsOpciones
    {

        public void ListaOpciones()
        {
            string opcionar = "0";
            double lista;
      
            List<double> Listanumeros = new List<double>();
            bool iniciar = true;

            while (iniciar)
            {
                Console.Clear();
                Console.WriteLine("     ************ CALCULADORA **********   ");
                Console.WriteLine("POR FAVOR SELECCIONE LA OPCION QUE DESEA REALIZAR");
                Console.WriteLine("1-  INGRESAR NÚMEROS");
                Console.WriteLine("2-  LISTAR NÚMEROS");
                Console.WriteLine("3-  SUMAR ");
                Console.WriteLine("4-  RESTAR ");
                Console.WriteLine("5-  MULTIPLICAR ");
                Console.WriteLine("6-  DIVIDIR ");
                Console.WriteLine("0-  SALIR ");


                opcionar = Console.ReadLine();


                switch (opcionar)
                {

                    case "1":
                        Console.WriteLine("Por Favor Ingrese Los Valores:");
                        lista = double.Parse(Console.ReadLine());
                        Listanumeros.Add(lista);
                        Console.WriteLine("Agregado: " + lista);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Su Lista de Números es:");
                        foreach (double numeros in Listanumeros)
                        {
                            Console.WriteLine(numeros);
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        double suma = 0;

                        foreach (double sumar in Listanumeros)
                        {
                            suma += sumar;
                        }
                        Console.WriteLine("La suma de los números que contiene la Lista es: " + suma);
                        Console.ReadKey();
                        break;
                    case "4":

                        double resta = Listanumeros[0];

                        foreach (double restar in Listanumeros.Skip(1))
                        {
                            resta = resta - restar;
                        }
                        Console.WriteLine("La resta de los numero que contiene la lista es: " + resta);
                        Console.ReadKey();
                        break;
                    case "5":

                        double multi = Listanumeros[0];

                        foreach (double multip in Listanumeros.Skip(1))
                        {
                            multi *= multip;
                        }
                        Console.WriteLine("La multiplicacion de su lista es: " + multi);
                        Console.ReadKey();
                        break;
                    case "6":

                        double dividir = Listanumeros[0];

                        foreach (double divi in Listanumeros.Skip(1))
                        {
                            dividir /= divi;
                        }
                        Console.WriteLine("la division de su lista es: " + dividir);
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Gracias Por Utilizar Nuestra Calculadora Vuelva Pronto");
                        Console.ReadKey();
                        iniciar = false;
                        break;
                    default:
                        Console.WriteLine("Por Favor Ingrese Una Opción Valida");
                        Console.ReadKey();
                        break;

                }
               // while (opcionar != "0") ;
            }
        }
    }
}