using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana5y6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer7();
            Console.ReadKey();
        }

        static void ejer1()
        {
            Console.Write("Ingrese num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese num 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (num1 == num2)
                Console.WriteLine("Los números son iguales");
            else if (num1 > num2)
                Console.WriteLine($"{num1} es mayor que {num2}");
            else
                Console.WriteLine($"{num2} es mayor que {num1}");
        }

        static void ejer2()
        {
            Console.Write("Ingrese in dia de semana: ");
            string dia = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
                Console.WriteLine("DÍA DE SEMANA");
            else if (dia == "sabado" || dia == "domingo")
                Console.WriteLine("FIN DE SEMANA");
            else
                Console.WriteLine("DÍA INVALIDO");
        }

        static void ejer3()
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (edad >= 18)
            {
                Console.WriteLine("Puede votar");
                if (edad >= 25)
                    Console.WriteLine("Puede postularse a un cargo político");
                else
                    Console.WriteLine("No puede postularse a un cargo político");
            }
            else
                Console.WriteLine("No puede votar ni postular a un cargo político");

        }

        static void ejer4()
        {
            Console.Write("Ingrese lado 1: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (lado1 == lado2 & lado1 == lado3)
                Console.WriteLine("Triangulo equilátero");
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                Console.WriteLine("Triangulo isósceles");
            else
                Console.WriteLine("Triangulo escaleno");
        }

        static void ejer5()
        {
            Console.WriteLine("Números de 0 al 20: ");
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(i + " ");
            }
        }

        static void ejer6()
        {
            for (int i = 50; i >= 20; i--)
            {
                Console.Write(i + " ");
            }
        }

        static void ejer7()
        {
            int suma = 0;
            for (int i = 0; i <= 100; i += 5)
            {
                Console.Write(i + " ");
                suma += i;
            }
            Console.WriteLine("\n\nSuma total: " + suma);
        }

        static void ejer8()
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int pares = 0, impares = 0, ceros = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                int num = int.Parse(Console.ReadLine());

                if (num == 0) ceros++;
                else if (num % 2 == 0) pares++;
                else impares++;
            }
            Console.WriteLine($"\nPares: {pares}\nImpares: {impares}\nCeros: {ceros}");
        }
    }
}
