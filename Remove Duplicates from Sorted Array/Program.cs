using System;
using System.Linq;

namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var res = RemoveDuplicates(new[] {0, 1, 1, 2, 3, 3, 4, 4});
            Console.WriteLine(res);
        }
        public static int RemoveDuplicates(int[] nums)
        {
            var dis = nums.Distinct();
            var j = 0;
            foreach (var i in dis)
            {
                nums[j] = i;
                j++;
            }
            return dis.Count();
        }
    }
}