using System;
using System.IO.Pipes;
using System.Linq;

namespace Remove_Element
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var res = RemoveElement(new[] {3, 2,2,3}, 3);
            Console.WriteLine();
        }
        public static int RemoveElement(int[] nums, int val)
        {
            var numsWithoutElement = nums.Where(x => x != val);
            var result = numsWithoutElement.Count();
            var j = 0;
            foreach (var i in numsWithoutElement)
            {
                nums[j] = i;
                j++;
            }

            return result;
        }
    }
}