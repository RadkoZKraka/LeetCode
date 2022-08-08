using System;
using System.Collections.Generic;

namespace CombinationSumIV
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var res = CombinationSum4(new[] {1, 2, 3}, 4);
            Console.WriteLine(res);
        }
        public static int CombinationSum4(int[] nums, int target)
        {
            var listOfCombinations = new List<int[]>();
            var list = new List<string>();
            var s = "";
            for (int i = 0; i < nums.Length; i++)
            {
                
            }

            return 3;
        }

        private static void CombinationsRec(ref string list, int num, int target)
        {
            // list.Add($"{num},{target - num}");
            while (target > 0)
            {
                
            }
        }
    }
}