using System;

namespace CaccamoVettoriNumero4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("stampo 100 valori e ti dico il più grande e il più piccolo");
            const int dimensione = 100;
            int[] numero = new int[dimensione];
            int grande = 0;
            int piccolo = 3001;
            Random generatore = new Random();
            for (int i = 0; i < dimensione; i++)
            {
                numero[i] = generatore.Next(1000, 3001);
            }
            for (int i = 0; i < dimensione; i++)
            {
                if (numero[i] > grande)
                {
                    grande = numero[i];
                }
                if (numero[i] < piccolo)
                {
                    piccolo = numero[i];
                }
            }
            Console.WriteLine("il numero più grande è " + grande);
            Console.WriteLine("il numero più piccolo è " + piccolo);
        }
    }
}
