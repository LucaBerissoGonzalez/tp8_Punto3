using System;
using System.Threading;

namespace tp8_Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int acumulador = 0;
            float promedio;

            int[] numeros = new int[6];

            Console.WriteLine("Ingrese Los 6 numeros de un array: ");
            Thread.Sleep(2000);
            Console.Clear();

            for (int i = 0; i < numeros.Length ; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i+1) + " del Array: ");
                num = Convert.ToInt32(Console.ReadLine());
                numeros[i] =  num;

            }

            for (int i = 0; i < numeros.Length ; i++)
            {
                acumulador = acumulador + numeros[i];
            }

            Console.Clear();

            promedio = (float)acumulador/6;

            Console.WriteLine("El Promedio es: " + promedio );

            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
