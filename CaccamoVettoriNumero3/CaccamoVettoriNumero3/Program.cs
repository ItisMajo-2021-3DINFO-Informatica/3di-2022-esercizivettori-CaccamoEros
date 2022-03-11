using System;

namespace CaccamoVettoriNumero3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stampo 30 valori e faccio la media");
            const int dimensione = 30;
            int[] numero = new int[dimensione];
            int media = 0;
            int somma = 0;
            int volte = 0;
            Random generatore = new Random();
            for (int i = 0; i < dimensione; i++)
            {
                numero[i] = generatore.Next(0, 51);
                somma = somma + numero[i];
                volte = volte + 1;
            }
            media = somma / volte;
            Console.WriteLine("la media dei tuoi valori è " + media);


        }
    }
}
