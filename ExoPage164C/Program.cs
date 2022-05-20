using System;
using System.Collections.Generic;

namespace ExoPage164C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de 
             * ces deux nombres en ne convertissant que caractère par caractère. 
             * (Méthode « ToCharArray() » de la classe « string »).
             */

            // Récupération des deux nombres
            string Number1 = Console.ReadLine();
            string Number2 = Console.ReadLine();

            /*
             * 123
             * { '1' , '2' , '3' }
             *  78
             * { '7', '8' }
             */
            // LIFO - Last In First Out
            Stack<char> CharNumber1 = new Stack<char>();
            Stack<char> CharNumber2 = new Stack<char>();
            Stack<int> StackResult = new Stack<int>();

            // Conversion des deux nombres en tableau de char
            // ToCharArray() pas nécessaire
            foreach (char digit in Number1)
            {
                CharNumber1.Push(digit);
            }

            foreach (char digit in Number2)
            {
                CharNumber2.Push(digit);
            }

            // Addition

            // Connaître le nombre de chiffres maximum dans mes stacks
            int MaxLength = CharNumber1.Count > CharNumber2.Count ? CharNumber1.Count : CharNumber2.Count;
            int Report = 0;

            // Boucler sur chaque chiffre du nombre le plus grand
            for (int i = 0; i < MaxLength; i++)
            {
                // Vérifier s'il y a valeur, récupérer la valeur du chiffre et la convertir en entier
                int Digit1 = CharNumber1.Count > 0 ? int.Parse(CharNumber1.Pop().ToString()) : 0;
                int Digit2 = CharNumber2.Count > 0 ? int.Parse(CharNumber2.Pop().ToString()) : 0;

                Console.WriteLine($"Nombres récupérés : {Digit1} : {Digit2}");

                int CurrentSum = Digit1 + Digit2 + Report;
                Report = 0;

                if (CurrentSum > 9)
                {
                    CurrentSum -= 10;
                    Report = 1;
                }

                Console.WriteLine($"Somme calculée : {CurrentSum} ~ Report de {Report}");

                // Ajouter le résutlat à la fin du tableau du résultat
                StackResult.Push(CurrentSum);

                if (CharNumber1.Count == 0 && CharNumber2.Count == 0 && Report > 0) StackResult.Push(Report);
            }

            //foreach (int digit in StackResult)
            //{
            //    Console.Write($" - {digit} - ");
            //}

            // StackResult.ToArray() -> Permet de transformer une liste en tableau
            // string.Join("", StackResult.ToArray()) -> Permet de fusionner le tableau en chaine de caractères
            // sur base d'un séparateur
            // Conversion vers un entier

            int Result = int.Parse(string.Join("", StackResult.ToArray()));

            Console.WriteLine($"{Number1} + {Number2} = {Result}");

        }
    }
}
