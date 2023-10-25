using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////
// Tarea: UD2T1
// Alumno/a: Verónica González Pons
// Curso: 2023/2024
///////////////////////////////////////////

namespace UD2T1GonzalezPonsVeronica
{
    internal class Program
    {
        static Empleado empleado = new Empleado("Aurelio", "Gonzalez", "Prieto", 23, "45892175Q", 436552);


        static void Main(string[] args)
        {
            int num = 1;
            while (num != 0)
            {
                Console.WriteLine("-------MENU--------");
                Console.Write("0 - Salir\r\n" +
                                  "1 - Crear empleado\r\n" +
                                  "2 - Actualizar salario\r\n" +
                                  "3 – Mostrar nombre\r\n" +
                                  "4 - Mostrar NIF\r\n" +
                                  "5 - Actualizar NIF\r\n" +
                                  "6 - Mostrar edad\r\n" +
                                  "7 – Mostrar empleado\r\n" +
                                  "Introduzca su opcion:");
                num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        num = 0;
                        Console.WriteLine("ADIOS!!");
                        break;
                    case 1:
                        num = 1;
                        Console.WriteLine(" ");
                        CrearEmpleado();
                        break;
                    case 2:
                        num = 2;
                        Console.WriteLine(" ");
                        ActualizarSalario();
                        break;
                    case 3:
                        num = 3;
                        Console.WriteLine(" ");
                        MostrarNombre();
                        break;
                    case 4:
                        num = 4;
                        Console.WriteLine(" ");
                        MostrarNif();
                        break;
                    case 5:
                        num = 5;
                        Console.WriteLine(" ");
                        ActualizarNif();
                        break;
                    case 6:
                        num = 6;
                        Console.WriteLine(" ");
                        MostrarEdad();
                        break;
                    case 7:
                        num = 7;
                        Console.WriteLine(" ");
                        MostrarEmpleado();
                        break;

                    default:
                        Console.WriteLine("Introduce un número del 0 al 7");
                        Console.WriteLine(" ");
                        break;

                }
                Console.WriteLine(" ");
            }

            void CrearEmpleado()
            {

                Console.WriteLine("Introduce el nombre del Empleado");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Introduce el apellido del empleado");
                empleado.Apellido = Console.ReadLine();
                Console.WriteLine("Introduce el segundo apellido del empleado");
                empleado.Apellido2 = Console.ReadLine();
                Console.WriteLine("Introduce la edad del empleado");
                empleado.Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el nif");
                empleado.Nif = Console.ReadLine();
                Console.WriteLine("Introduce la salario del empleado");
                empleado.Salario = double.Parse(Console.ReadLine());

            }


            void ActualizarSalario()
            {

                Console.WriteLine("Actualiza el salario");
                empleado.Salario = double.Parse(Console.ReadLine());

            }


            void MostrarNombre()
            {
                NombreCompleto();


            }


            void NombreCompleto()
            {
                Console.WriteLine("Nombre: " + empleado.Nombre
                                 + " " + empleado.Apellido
                                 + " " + empleado.Apellido2);
            }


            void MostrarNif()
            {
                Console.WriteLine("Nif: " + empleado.Nif);
            }


            void ActualizarNif()
            {
                Console.WriteLine("Actualiza el nif");
                empleado.Nif = Console.ReadLine();
            }


            void MostrarEdad()
            {
                Console.WriteLine("Edad: " + empleado.Edad + " años");
            }


            void MostrarEmpleado()
            {
                NombreCompleto();
                MostrarEdad();
                MostrarNif();
                Console.WriteLine("Salario: " + empleado.Salario + " eur");

            }

        }
    }
}
