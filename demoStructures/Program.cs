using demoStructures.Models;
using System;
using System.Collections.Generic;

namespace demoStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //{ 
            //    "maman@csharp.be" : { "firstname" : "Béatrice", "lastname" :"nomDeFamille"},
            //    "papa@csharp.be" : { "firstname" : "Béatrice", "lastname" :"nomDeFamille"},
            //    "moi@csharp.be" : { "firstname" : "Béatrice", "lastname" :"nomDeFamille"},
            //}

            Dictionary<string, Contact> Repertoire = new Dictionary<string, Contact>();

            Contact Maman;
            Maman.Pseudo = "Maman";
            Maman.FirstName = "Béatrice";
            Maman.LastName = "NomDeFamille";
            Maman.MailAddress = "maman@csharp.be";

            Contact Papa;
            Papa.Pseudo = "Papa";
            Papa.FirstName = "Jean-Pierre";
            Papa.LastName = "NomDeFamille";
            Papa.MailAddress = "papa@csharp.be";

            Contact Moi;
            Moi.Pseudo = "Moi";
            Moi.LastName = "Geerts";
            Moi.FirstName = "Quentin";
            Moi.MailAddress = "quentin.geerts@bstorm.be";

            // Ajouter les contacts au répertoire
            Repertoire.Add(Maman.MailAddress, Maman);
            Repertoire.Add(Papa.MailAddress, Papa);
            Repertoire.Add(Moi.MailAddress, Moi);


            foreach (KeyValuePair<string, Contact> contact in Repertoire)
            {
                Console.WriteLine(contact.Key);
                Console.WriteLine(contact.Value.FirstName + " " + contact.Value.LastName);
                Console.WriteLine();
            }

            Console.WriteLine("~~ Création du message ~~");

            Message Message;
            Message.Sender = Repertoire[Moi.MailAddress];
            Message.Recipient = Repertoire[Maman.MailAddress];

            Message.Object = "Repas de ce soir !";

            Message.Content = "N'oublie pas d'acheter des carottes pour ce soir. Je t'aime ! ♥";
            Message.SendHours = DateTime.Now;

            Message.Receipt = false;


            Console.WriteLine($"{Message.Recipient.Pseudo}");
            Console.WriteLine($"{Message.Object}");
            Console.WriteLine($"{Message.Content}");
            Console.WriteLine($"{Message.Receipt}");
        }
    }
}
