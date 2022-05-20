using System;
using System.Collections;

namespace ExoPage164A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Grâce à une boucle « while » et à l’aide d’une collection, 
             * calculez les nombres premiers inférieur à un nombre entier 
             * entré au clavier.
             */

            Queue PrimeNumbers = new Queue();

            Console.WriteLine("Entrez un nombre (limite à atteindre) :");
            int MaxValue = int.Parse(Console.ReadLine());


            int CurrentValue = 2;

            while (CurrentValue < MaxValue)
            {
                bool IsPrimeNumber = true;
                int Divider = 2;

                while (Divider < CurrentValue)
                {
                    if (CurrentValue % Divider == 0) IsPrimeNumber = false;
                    Divider++;
                }

                if (IsPrimeNumber) PrimeNumbers.Enqueue(CurrentValue);

                CurrentValue++;
            }

            foreach (int Number in PrimeNumbers)
            {
                Console.WriteLine(Number);
            }
        }
    }
}
