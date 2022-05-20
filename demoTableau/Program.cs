using System;

namespace demoTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            string[] str = new string[10];

            str[4] = "Coucou";

            for ( int i = 0; i < tab.Length; i++ )
            {
                Console.WriteLine(tab[i]);
            }

            for ( int i = 0; i < str.Length; i++ )
            {

                //str[i] = str[i] ?? "Valeur";
                str[i] ??= "Valeur";


                if ( str[i] == null ) Console.WriteLine("La valeur est nulle");
                else Console.WriteLine(str[i]);
            }

            //string[] eleves = { "Michel", "Mike", "Noémie", "Max", "JF" };

        }
    }
}
