using System;
using System.Collections.Generic;
using System.Linq;

namespace The_K_Weakest_Rows_in_a_Matrix
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            int [][] test = new int[][]
            {
                new int[] { 0, 0, 0, 1, 1 },
                new int[] { 0, 1, 1, 1, 1},
                new int[] { 0, 1, 0, 0, 0},
                new int[] { 1, 1, 0, 0, 0},
                new int[] { 1, 1, 1, 1, 1 }
            };
            var lol = KWeakestRows(test,3);
            Console.WriteLine(lol[1]);
        }
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            var rowDict = new Dictionary<int, int>();
            for (int i = 0; i < mat.Length; i++)
            {
                rowDict.Add(i, mat[i].Sum());
            }

            var result = rowDict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x=> x.Value);
            return result.Keys.Take(k).ToArray();
        }
    }
}