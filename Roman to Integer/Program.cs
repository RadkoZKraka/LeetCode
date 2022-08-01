using System;
using System.Collections.Generic;

namespace Roman_to_Integer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(RomanToInt("MMLIX"));
        }
        public static int RomanToInt(string s)
        {
            
            
            var romanDictionary = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            var temp = s.ToUpper();
            var result = 0;
            for (int i = 0; i < temp.Length; i++)
            {

                if (i == temp.Length - 1)
                {
                    result += romanDictionary[temp[i]];
                    break;
                } 
                if (romanDictionary[temp[i + 1]] > romanDictionary[temp[i]])
                {
                    result += romanDictionary[temp[i + 1]] - romanDictionary[temp[i]];
                    i++;
                    continue;
                }

                result += romanDictionary[temp[i]];
            }

            return result;
        }
    }
}