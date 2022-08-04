using System;
using System.Collections.Generic;
using System.Linq;

namespace Isomorphic_strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsIsomorphic("egg","add"));
        }
        public static bool IsIsomorphic(string s, string t)
        {
            var sUnique = new Dictionary<char,int>()
            {
                {s[0],0}
            };
            var tUnique = new Dictionary<char, int>()
            {
                {t[0],0}
            };
            var resultS = "";
            var resultT = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (!sUnique.ContainsKey(s[i]))
                {
                    sUnique.Add(s[i], sUnique[s[i - 1]] + 1);

                }

                resultS += "," + sUnique[s[i]];
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!tUnique.ContainsKey(t[i]))
                {
                    tUnique.Add(t[i], tUnique[t[i - 1]] + 1);
                }

                resultT += "," + tUnique[t[i]];
            }
            
            return resultS == resultT;
        }
    }
}