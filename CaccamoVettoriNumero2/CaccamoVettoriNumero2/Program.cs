using System;

namespace CaccamoVettoriNumero2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Console.WriteLine("stampo 100 valori, ma solo quelli superiori a 50");
            const int dimensione = 100;
            int[] numero = new int[dimensione];
            Random generatore = new Random();
            for (int i = 0; i < dimensione; i++)
            {
                numero[i] = generatore.Next(0, 101);
            }
            for (int i = 0; i < dimensione; i++)
            {
                if (numero[i] > 50)
                {
                    c = c + 1;
                }
            }
            Console.WriteLine("sono stati stampati " + c + " valori");
        }
    }
}
