using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_common_prefix
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var res = LongestCommonPrefix(new []{"flopzx", "flogew", "flow"});
            Console.WriteLine(res);
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            var shortest = strs.OrderBy(x => x.Length).FirstOrDefault();
            if (string.IsNullOrEmpty(shortest)) return "";
            if (strs.Length == 1) return strs[0];
            var res = "";
            for (int i = 0; i < shortest.Length; i++)
            {
                var temp = res + shortest[i];
                if (strs.ToList().TrueForAll(x => x.StartsWith(temp)))
                {
                    res = temp;
                }
                else
                {
                    break;
                }
            }

            return res;
        }

        public static string Longest(string[] strs)
        {
            var st = new Stack<char>();
            var res = "";
            var shortest = strs.OrderBy(x => x.Length).FirstOrDefault();
            if (string.IsNullOrEmpty(shortest))
            {
                return "";
            }
            st.Push(shortest[0]);
            for (int i = 1; i < shortest.Length; i++)
            {  
                st.Push(shortest[i]);
                if (strs.ToList().TrueForAll(x => x.StartsWith(String.Join("", st.Reverse()))))
                {
                    continue;
                }
                else
                {
                    st.Pop();
                    break;
                }
            }

            return String.Join("", st.Reverse());
        }
    }
}