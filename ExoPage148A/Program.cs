using System;

namespace ExoPage148A
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Calculer les 25 premiers nombres de la suite de Fibonacci.
             */

            int nb1 = 0, nb2 = 1, temp;

            for ( int i = 0; i < 25; i++ )
            {
                Console.WriteLine($"{nb1}");

                temp = nb1 + nb2;
                nb1 = nb2;
                nb2 = temp;
            }

        }
    }
}
