using System;
using System.Collections.Generic;
using System.Linq;

namespace Playground
{
    

    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
        
        public static string LongestCommonPrefix(string[] strs)
        {
            var shortest = strs.OrderBy(x => x.Length).FirstOrDefault();
            if (strs.Length == 1) return strs[0];

            if (String.IsNullOrEmpty(shortest)) return "";
            var temp = strs.ToList();
            var result = "";
            for (int i = 0; i < shortest.Length + 1; i++)
            {
                if (temp.TrueForAll(x => x.StartsWith(shortest[0].ToString())) == false) return "";
                var temp2 = shortest.Substring(0, i);
                var res = temp.TrueForAll(x => x.StartsWith(temp2));
                if (res == false)
                {
                    return result;
                }

                result = shortest.Substring(0, i);

                if (shortest.Length == 1)
                {
                    result = shortest.Substring(0, i + 1);
                }
            }

            return result;
        }

        public bool IsPalindrome(int x)
        {
            return x.ToString().SequenceEqual(x.ToString().Reverse());
        }
    }
}