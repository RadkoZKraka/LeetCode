using System;
using System.Collections.Generic;
using System.Linq;

namespace Kth_Smallest_Element_in_a_Sorted_Matrix
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var temp = KthSmallest(new[]
            {
                new[] {1, 5, 9},
                new []{10,11,13},
                new []{12,13,15}

            }, 8);
            Console.WriteLine(temp);
        }
        public static int KthSmallest(int[][] matrix, int k)
        {
            var temp = matrix.Select(x => String.Join(",", x));
            var temp2 = Array.ConvertAll(String.Join(",", temp).Split(','), s => int.Parse(s)).OrderBy(x=>x).ToArray();
            // return Char.GetNumericValue(temp2[k]);
            return temp2[k-1];
        }
    }
}