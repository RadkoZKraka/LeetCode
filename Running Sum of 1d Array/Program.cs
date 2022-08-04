using System.Linq;

namespace Running_Sum_of_1d_Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public int[] RunningSum(int[] nums)
        {
            //rozwiązanie 1 -> szybsze
            
            return nums.Select((x, i) => nums.Take(i + 1).Sum()).ToArray();
            
            //rozwiązanie 2 -> okropne
            
            // var result = new int[nums.Length];
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     result[i] = nums.Take(i + 1).Sum();
            // }
            //
            // return result;
        }
    }
}