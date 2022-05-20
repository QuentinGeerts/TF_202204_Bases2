using System;

namespace ExoPage148B
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Calculer la factoriel d'un nombre entré au clavier
             */

            Console.WriteLine("Entrez un nombre (factoriel) : ");
            int number = int.Parse(Console.ReadLine());

            for ( int i = number - 1; i > 1; i-- )
            {
                number *= i;
            }

            Console.WriteLine("le résultat vaut " + number);

        }
    }
}
