using System;

namespace demoTableauOrtho
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = { new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10, 11 }, };

            Console.WriteLine(tab[0][2]);

            Console.WriteLine(tab.Length); // 2
            Console.WriteLine(tab[0].Length); // 5
            Console.WriteLine(tab[1].Length); // 6



            for ( int i = 0; i < tab.Length; i++ )
            {
                Console.Write("[");

                for ( int j = 0; j < tab[i].Length; j++ )
                {
                    Console.Write($"{tab[i][j]}");
                    if ( j < tab[i].Length - 1 ) Console.Write(", ");
                }

                Console.WriteLine("]");

            }

        }
    }
}
