using System;
using System.Collections.Generic;

namespace Generic
{
   public class Program
    {
        public static void Main(string[] args)
        {
            List<string> Foods  = new List<string>();

            

            Foods.Add("Bread");
            Foods.Add("Tea");
            Foods.Add("Sugar,Salt");
            Foods.Add("Coffe");
            Foods.Add("Oil");
            Console.WriteLine();
            foreach (string Food in Foods)
            {
                Console.WriteLine(Foods);
            }

          
            Console.WriteLine("Count: {0}", Foods.Count);

            Console.WriteLine("\nContains(\"Tea\"): {1}",
                Foods.Contains("Tea"));

            Console.WriteLine("\nInsert(3, \"Sugar,Salt\")");
            Foods.Insert(3, "Sugar,Salt");

            Console.WriteLine();
            foreach (string Food in Foods)
            {
                Console.WriteLine(Foods);
            }

            Console.WriteLine("\nFoods[3]: {0}", Foods[3]);

            Console.WriteLine("\nRemove(\"Sugar,Salt\")");
            Foods.Remove("Sugar,Salt");

            Console.WriteLine();
            foreach (string Food in Foods)
            {
                Console.WriteLine(Foods);
            }

           
            Foods.Clear();
            Console.WriteLine("\nClear()");
            Console.WriteLine("Count: {0}", Foods.Count);

        }
    }
}
