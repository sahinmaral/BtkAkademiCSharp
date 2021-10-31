using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayListDemo();

            // ListDemo();

            //DictionaryDemo();

        }

        private static void DictionaryDemo()
        {
            Dictionary<int, string> personLogs = new Dictionary<int, string>();

            personLogs.Add(1111111111, "ali keser");
            personLogs.Add(1111111112, "veli keser");
            personLogs.Add(1111111113, "hasan keser");

            foreach (var person in personLogs)
            {
                System.Console.WriteLine(person);
            }

            System.Console.WriteLine(personLogs.ContainsKey(1111111111));
        }

        private static void ListDemo()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            cities.ForEach(x => System.Console.WriteLine(x));
        }

        private static void ArrayListDemo()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                System.Console.WriteLine(city);
            }
        }
    }

}
