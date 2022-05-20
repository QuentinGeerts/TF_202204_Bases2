using System;

namespace ExoPage148C
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Grâce à une boucle "for", calculez les x premiers nombre premiers.
             */

            Console.WriteLine("Combien de nombre premier voulez-vous ? ");
            int userNumber = int.Parse(Console.ReadLine());
            int nbFound = 0;

            for ( int nbToAnalyze = 2; nbFound < userNumber; nbToAnalyze++ )
            {
                bool isPrimeNumber = true;
                int cpt = 0;

                for ( int div = 1; div <= nbToAnalyze; div++ )
                {
                    if ( nbToAnalyze % div == 0 ) cpt++;
                }

                isPrimeNumber = cpt == 2;

                if (isPrimeNumber)
                {
                    nbFound++;
                    Console.WriteLine(nbToAnalyze);
                }
            }

        }
    }
}
