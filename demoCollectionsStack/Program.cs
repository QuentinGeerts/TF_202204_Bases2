using System;
using System.Collections;

namespace demoCollectionsStack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack
            // LIFO => Last In First Out

            Stack pileAssiettes = new Stack();

            pileAssiettes.Push("Assiette 1");
            pileAssiettes.Push("Assiette 2");
            pileAssiettes.Push("Assiette 3");
            pileAssiettes.Push("Assiette 4");
            pileAssiettes.Push("Assiette 5");

            Console.WriteLine(pileAssiettes.Peek());
            Console.WriteLine(pileAssiettes.Peek());
            Console.WriteLine(pileAssiettes.Peek());
            Console.WriteLine(pileAssiettes.Peek());
            Console.WriteLine(pileAssiettes.Peek());

            int nbAssiettes = pileAssiettes.Count;

            for ( int i = 0; i < nbAssiettes; i++ )
            {
                string assiette = (string) pileAssiettes.Pop();
                Console.WriteLine($"Assite '{assiette}' nettoyée");
            }

            Console.WriteLine("Lavage terminé.");


        }
    }
}
