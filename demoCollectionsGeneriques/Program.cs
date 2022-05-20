using System;
using System.Collections.Generic;

namespace demoCollectionsGeneriques
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              
            ArrayList       -> List<T>
            Hashtable       -> Dictionary<T, U>
            Queue           -> Queue<T>
            Stack           -> Stack<T>
              
            */

            #region List<T>

            List<string> students = new List<string>();

            students.Add("Quentin");
            students.Add("Michel");
            students.Add("JF");
            students.Add("Mike");

            students.AddRange(new List<string>() { "Stéphane", "Seifallah", "Valentin" });

            List<string> students2 = new List<string>(students);

            //students2.AddRange(students);

            students.Remove("Quentin");

            students.Add("Julien");

            students2.RemoveAt(3);

            Console.WriteLine("Liste de mes élèves 1 : ");

            foreach ( string student in students )
            {
                Console.WriteLine($" - {student}");
            }

            Console.WriteLine("Liste de mes élèves 2 : ");

            foreach (string student in students2)
            {
                Console.WriteLine($" - {student}");
            }

            #endregion

            #region Dictionary<T, U>

            Dictionary<string, string> dictionnaire = new Dictionary<string, string>();

            if (!dictionnaire.ContainsKey("CSharp")) dictionnaire.Add("CSharp", "Superbe langage !");
            
            
            if (!dictionnaire.ContainsKey("CSharp")) dictionnaire.Add("CSharp", "Superbe langage !");
            else dictionnaire["CSharp"] = "Magnifique langage de programmation !";

            if (!dictionnaire.ContainsKey("top")) dictionnaire.Add("top", "Blabla");
            if (!dictionnaire.ContainsKey("top2")) dictionnaire.Add("top2", "Blabla");
            if (!dictionnaire.ContainsKey("top3")) dictionnaire.Add("top3", "Blabla");
            if (!dictionnaire.ContainsKey("top4")) dictionnaire.Add("top4", "Blabla");



            foreach (KeyValuePair<string, string> KeyValue in dictionnaire)
            {
                Console.WriteLine("Définition pour " + KeyValue.Key);
                Console.WriteLine(" - " + KeyValue.Value);
            }
            #endregion

            #region Queue<T>

            Queue<string> clients = new Queue<string>();

            clients.Enqueue("Client 1");
            clients.Enqueue("Client 2");
            clients.Enqueue("Client 3");

            if ( clients.Count > 0 ) clients.Dequeue();
            else Console.WriteLine("Plus de client.");

            if (clients.Count > 0) clients.Dequeue();
            else Console.WriteLine("Plus de client.");

            if (clients.Count > 0) clients.Dequeue();
            else Console.WriteLine("Plus de client.");

            if (clients.Count > 0) clients.Dequeue();
            else Console.WriteLine("Plus de client.");

            #endregion

            #region Stack<T>
            Stack<string> factures = new Stack<string>();

            factures.Push("Facture 1");
            factures.Push("Facture 2");
            factures.Push("Facture 3");
            factures.Push("Facture 4");

            Console.WriteLine(factures.Peek());
            Console.WriteLine(factures.Peek());
            Console.WriteLine(factures.Peek());
            Console.WriteLine(factures.Peek());

            int nbFactures = factures.Count;

            for ( int i = 0; i < nbFactures; i++ )
            {
                string facture = factures.Pop();
                Console.WriteLine($"Facture '{facture}' réglée."); 
            }


            //factures.Push(12);
            #endregion

        }
    }
}
