using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2.Clases
{
    internal class clsLogin
    {
        public void Logueo()
        {
            int intentos = 1;
            string claveCorrecta = "123";
            string clave;
            string nombre;

            Console.Clear();
            Console.WriteLine("Bienvenidos al Curso Chalo CODE");
            Console.WriteLine("Actividad # 2");
            Console.WriteLine("Presentado por Carlos Ardila");

            Console.WriteLine("------------------------------------------");

            do
            {
                Console.WriteLine("Por favor Ingrese su Nombre");
                nombre = Console.ReadLine();

                Console.WriteLine(" Por favor ingrese la clave de ingreso <Intento # " + intentos +" >");
                clave = Console.ReadLine();

                if (clave == claveCorrecta)
                {
                    Console.WriteLine(" Bienvenido " + nombre);
                    break;
                }else
                {
                    intentos++;
                    Console.WriteLine("Clave Incorrecta");
                }
            } while (intentos <=5 );

            Console.ReadKey();
        }
    }
}
