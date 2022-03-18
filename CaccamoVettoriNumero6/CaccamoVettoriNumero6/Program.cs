using System;

namespace CaccamoVettoriNumero6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il valore del tempo che 8 atleti hanno totalizzato in una gara di nuoto");
            const int dimensione = 8;
            int[] corsia = new int[dimensione];
            Random generatore = new Random();
            int maggiore = 0;
            int scarto1 = 0;
            int scarto2 = 0;
            int scarto3 = 0;
            int scarto4 = 0;
            int scarto5 = 0;
            int scarto6 = 0;
            int scarto7 = 0;
            int scarto8 = 0;
            for (int i = 0; i < dimensione; i++)
            {
                int tempoSecondi = generatore.Next(20, 61);
                corsia[i] = tempoSecondi;
                Console.WriteLine("il tempo che ci hanno impiegato è "+ corsia[i]);
                if (corsia[i]>maggiore)
                {
                    maggiore = corsia[i];
                }
                if (corsia[0] != maggiore)
                {
                    scarto1 = maggiore - corsia[0];
                }
                if (corsia[1] != maggiore)
                { 
                    scarto2 = maggiore - corsia[1];
                }
                if (corsia[2] != maggiore)
                { 
                    scarto3 = maggiore - corsia[2];
                }
                if (corsia[3] != maggiore)
                { 
                    scarto4 = maggiore - corsia[3];
                }
                if (corsia[4] != maggiore)
                { 
                    scarto5 = maggiore - corsia[4];
                }
                if (corsia[5] != maggiore)
                { 
                    scarto6 = maggiore - corsia[5];
                }
                if (corsia[6] != maggiore)
                { 
                    scarto7 = maggiore - corsia[6];
                }
                if (corsia[7] != maggiore)
                { 
                    scarto8 = maggiore - corsia[7];
                }
            }
            
            Console.WriteLine("il maggiore è " + maggiore);
            Console.WriteLine(scarto1);
            Console.WriteLine(scarto2);
            Console.WriteLine(scarto3);
            Console.WriteLine(scarto4);
            Console.WriteLine(scarto5);
            Console.WriteLine(scarto6);
            Console.WriteLine(scarto7);
            Console.WriteLine(scarto8);
        }
    }
}
