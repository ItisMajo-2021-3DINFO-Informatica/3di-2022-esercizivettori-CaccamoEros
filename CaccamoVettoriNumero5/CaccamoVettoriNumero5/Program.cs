using System;

namespace CaccamoVettoriNumero5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stampo 1000 valori tra 1 e 250 e ti dico la percentuale di quelli minori a 175");
            const int dimensione = 1000;
            int[] numero = new int[dimensione];
            Random generatore = new Random();
            float percentuale = 0;
            float volte = 0;
            for (int i = 0; i < dimensione; i++)
            {
                numero[i] = generatore.Next(1, 251);
                
            }
            for (int i = 0; i < dimensione; i++)
            {
                if (numero[i] < 175)
                {
                    volte = volte + 1;
                }
            }
            percentuale = volte * 100 / dimensione;
            Console.WriteLine("la percentuale delle volte che i numeri erano minori a 175 è " + percentuale + "%");
        }
    }
}
