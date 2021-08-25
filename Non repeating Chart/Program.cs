using System;
using System.Collections.Generic;

namespace Non_repeating_Chart
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool first = true;
            List<char> charcaters = new List<char>();
            List<char> repeated = new List<char>();


            foreach (char c in input)
            {
                if (charcaters.Contains(c))
                {
                    repeated.Add(c);
                }
                charcaters.Add(c);
             }

            foreach(char c in charcaters)
            {
                if (!repeated.Contains(c))
                {
                    if (first)
                    {
                        Console.WriteLine($"{c.ToString()}");
                        Console.WriteLine(string.Format("First unrepeated char:{0}", c.ToString()));
                        first = false;
                    }
                }
            }


        }
    }
}
