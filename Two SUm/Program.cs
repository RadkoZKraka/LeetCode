using System;
using System.Collections;


class Program
{
    static void Main(string[] args)
    {
        var res = TwoSum(new []{ 1234, 5678, 9012 }, 14690);
        Console.WriteLine(res);
    }
    public static int[] TwoSum(int[] nums, int target) {
        if (nums.Length < 2)
        {
            return Array.Empty<int>();
        }
        foreach (var num in nums)
        {
            var temp = target - num;
            if (!((IList) nums).Contains(temp) && temp == num)
            {
                continue;
            }

            return new []{Array.IndexOf(nums, num), Array.LastIndexOf(nums, temp)};
        }

        return Array.Empty<int>();
    }
}