using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var num = FizzBuzz(3);
            Console.WriteLine();
        }
        public static IList<string> FizzBuzz(int n)
        {
            var list = new List<string>();
            for (int i = 1; i < n + 1; i++)
            {
                if (i % 5 != 0 && i % 3 != 0)
                {
                    list.Add(i.ToString());
                    continue;
                }
                if (i % 3 != 0)
                {
                    list.Add("Buzz");
                    continue;
                }
                if (i % 5 != 0)
                {
                    list.Add("Fizz");
                    continue;
                }
                list.Add("FizzBuzz");
            }

            return list;
        }
    }
}