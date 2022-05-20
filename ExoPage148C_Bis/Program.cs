using System;

namespace ExoPage148C_Bis
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

                for ( int div = 2; div < nbToAnalyze; div++ )
                {
                    if ( nbToAnalyze % div == 0 ) isPrimeNumber = false;
                }


                if ( isPrimeNumber )
                {
                    nbFound++;
                    Console.WriteLine(nbToAnalyze);
                }
            }
        }
    }
}
