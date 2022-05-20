using System;
using System.Collections;

namespace demoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList students = new ArrayList();

            //Console.WriteLine(students.Count); // 0
            //Console.WriteLine(students.Capacity); // 0

            students.Add("Noémie");
            students.Add("Mike");
            students.Add("Michel");
            students.Add("Stéphane");

            //Console.WriteLine(students.Count); // 4
            //Console.WriteLine(students.Capacity); // 4

            students.Remove("Michel");

            //Console.WriteLine(students.Count); // 3
            //Console.WriteLine(students.Capacity); // 4

            students.AddRange(new ArrayList() { "Quentin", "Loïc" });

            //Console.WriteLine(students.Count); // 5



            students.Add(12);

            students.Insert(3, "Ines");
            int i = 0;

            foreach (var item in students)
            {
                Console.WriteLine($"students[{i}] = {item}");
                i++;
            }
            #endregion

            #region HashTable
            Hashtable dictionnaire = new Hashtable();

            dictionnaire.Add("00001", "Quentin");
            dictionnaire.Add(2020, "Informatique de gestion");

            Console.WriteLine(dictionnaire["00001"]); // "Quentin"
            Console.WriteLine(dictionnaire[2020]);
            Console.WriteLine(dictionnaire[32]);

            dictionnaire.Remove(2020);

            Console.WriteLine(dictionnaire.ContainsKey(2020));

            if (!dictionnaire.ContainsKey("00001")) dictionnaire.Add("00001", "Michel");
            else Console.WriteLine("La clef 00001 existe déjà.");

            #endregion




        }
    }
}
