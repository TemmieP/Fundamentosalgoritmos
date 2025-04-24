using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio6();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            int num1;

            Console.Write("Ingrese un número entero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("\nEl número es par");
            }
            else
            {
                Console.WriteLine("\nEl número es impar");
            }
        }

        static void ejercicio2()
        {
            int edad;

            Console.Write("Ingrese una edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad < 0)
            {
                Console.WriteLine("\nEdad inválida!");
            }
            else
            {
                if (edad < 18)
                {
                    Console.WriteLine("\nEs menor de edad");
                }
                else
                {
                    Console.WriteLine("\nEs mayor de edad");
                }
            }
        }

        static void ejercicio3()
        {
            int sbase;
            double smari, sjuan, spatri, suma;
            Console.Write("Ingrese el sueldo base: ");
            sbase = int.Parse(Console.ReadLine());

            smari = (sbase - (sbase * 0.05)) - 25;
            sjuan = (sbase + (sbase * 0.23)) + 72;
            spatri = (sbase + (sbase * 0.05)) - 56;
            suma = smari + sjuan + spatri;
            Console.WriteLine("**********SUELDOS DE TRABAJADORES*************");
            Console.WriteLine("Sueldo de María: " + smari);
            Console.WriteLine("Sueldo de Juan: " + sjuan);
            Console.WriteLine("Sueldo de Patricio: " + spatri);
            Console.WriteLine("**********SUMA DE SUELDOS =" + suma + "*************");
        }
        static void ejercicio4()
        {
            int año;

            Console.WriteLine("Ingrese el año a determinar: ");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
            {
                Console.WriteLine("El año: " + año + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año: " + año + " no es bisiesto");
            }
        }
        static void ejercicio5()
        {
            double sol;
            int opcion;
            Console.WriteLine("Ingrese la cantidad de soles a convertir: ");
            sol = double.Parse(Console.ReadLine());
            Console.WriteLine("Opciones: [1] Dolares | [2] Euros");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    double dolares = sol / 3.75;
                    Console.WriteLine($"{sol} soles equivalen a {dolares.ToString("0.00")} EUR");
                    break;

                case 2:
                    double euros = sol / 4.05;
                    Console.WriteLine($"{sol} soles equivalen a {euros.ToString("0.00")} EUR");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor seleccione 1 o 2.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
        static void ejercicio6()
        {
            int opcion;
            double area,b,h,r;
            Console.WriteLine("Opciones: [1] Cuadrado | [2] Rectángulo | [3] Triángulo | [4] Círculo");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    double l;
                    Console.WriteLine("Ingrese el lado del cuadrado: ");
                    l = double.Parse(Console.ReadLine());
                    area = Math.Pow(l, 2);
                    Console.WriteLine("El área del cuadrado es: " + area);
                    break;

                case 2:

                    Console.WriteLine("Ingrese la base del rectángulo: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del rectángulo: ");
                    h = double.Parse(Console.ReadLine());

                    area = b * h;
                    Console.WriteLine("El área del rectángulo es: " + area);
                    break;
                case 3:

                    Console.WriteLine("Ingrese la base del triángulo: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del triángulo: ");
                    h = double.Parse(Console.ReadLine());

                    area = (b * h) / 2;
                    Console.WriteLine("El área del rectángulo es: " + area);
                    break;
                case 4:
                    {
                        Console.WriteLine("Ingrese el radio del círculo: ");
                        r= double.Parse(Console.ReadLine());
                        area= Math.PI * Math.Pow(r, 2);
                        Console.WriteLine("El radio del círculo es: " + area);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no valida, elija una opción del 1 al 4.");
                        break;
                    }
            }
        }
    }
}
