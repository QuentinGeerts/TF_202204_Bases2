using System;
using System.Collections.Generic;

namespace ExoPage164B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Grâce à une boucle « for » et à l’aide d’une collection générique, 
             * calculez les x premiers nombres premiers (version optimisée).
             */

            List<int> PrimeNumbers = new List<int>();

            Console.WriteLine("Combien de nombre premier voulez-vous ? ");
            int UserNumber = int.Parse(Console.ReadLine());

            for (int CurrentValue = 2; PrimeNumbers.Count < UserNumber; CurrentValue++)
            {
                bool isPrimeNumber = true;

                for (int Divider = 2; Divider < CurrentValue; Divider++)
                {
                    if (CurrentValue % Divider == 0) isPrimeNumber = false;
                }

                if (isPrimeNumber) PrimeNumbers.Add(CurrentValue);
            }

            foreach (int PrimeNumber in PrimeNumbers)
            {
                Console.WriteLine(PrimeNumber);
            }
        }
    }
}
