using System;

namespace CaccamoVettoriNumero1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stampare 400 valori");
            const int dimensione = 400;
            int[] numero = new int[dimensione];
            Random generatore = new Random();
            for (int i = 0; i < dimensione; i++)
            {
                numero[i] = generatore.Next(0, 101);
                Console.WriteLine(numero[i]);
            }
        }
    }
}
