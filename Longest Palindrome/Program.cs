using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Palindrome
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var res = LongestPalindrome("abccccdd");
            Console.WriteLine(res);
        }
        public static int LongestPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return 0;
            }
            var charDict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (charDict.ContainsKey(c))
                {
                    charDict[c]++;
                    continue;
                }

                charDict.Add(c, 1);
            }

            var possibilitiesEven = charDict.Values.Where(x => x % 2 == 0);
            var possibilitiesOdd = charDict.Values.Where(x => x % 2 == 1);
            var result = possibilitiesOdd.Where(x => x > 1).Select(x => x - 1);
            var res = 0;
            if (possibilitiesOdd.Count() != 0)
            {
                res = result.Sum() + 1;
            }

            return possibilitiesEven.Sum() + res;
        }
    }
}