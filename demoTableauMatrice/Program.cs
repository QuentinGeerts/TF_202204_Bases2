using System;

namespace demoTableauMatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }};

            //Console.WriteLine(m.Length);

            //Console.WriteLine(m[2, 2]);

            for ( int i = 0; i < m.Rank; i++ )
            {
                Console.WriteLine($"m.Rank : {m.Rank}");
                Console.WriteLine($"Tableau {i + 1}");
                for ( int j = 0; j < m.GetLength(i); j++ )
                {

                    Console.WriteLine($"m.GetLength({i}) : {m.GetLength(i)}");
                    Console.WriteLine(m[i, j]);
                }
            }

        }
    }
}
