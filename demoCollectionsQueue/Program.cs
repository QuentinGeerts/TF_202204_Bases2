using System;
using System.Collections;

namespace demoCollectionsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fileAttente = new Queue();
            // FIFO => First In First Out

            fileAttente.Enqueue("Client 1");
            fileAttente.Enqueue("Client 2");
            fileAttente.Enqueue("Client 3");
            fileAttente.Enqueue("Client 4");
            fileAttente.Enqueue("Client 5");
            fileAttente.Enqueue("Client 6");

            Console.WriteLine("Nombre de clients " + fileAttente.Count);

            Console.WriteLine(fileAttente.Peek()); 
            Console.WriteLine(fileAttente.Peek()); 
            Console.WriteLine(fileAttente.Peek()); 
            Console.WriteLine(fileAttente.Peek()); 
            Console.WriteLine(fileAttente.Peek()); 

            Console.WriteLine("Traitement des clients : ");
            int nbClients = fileAttente.Count;

            //for ( int i = 0; i < nbClients; i++ )
            //{
            //    Console.WriteLine("Client n°" + (i + 1));
            //    string client = (string) fileAttente.Dequeue();

            //    Console.WriteLine(client);
            //}

            int i = 0;
            while (fileAttente.Count > 0)
            {
                Console.WriteLine("Client n°" + (i + 1));
                string client = (string)fileAttente.Dequeue();

                Console.WriteLine(client);
                i++;
            }

            Console.WriteLine(fileAttente.Count); // 0

        }
    }
}
