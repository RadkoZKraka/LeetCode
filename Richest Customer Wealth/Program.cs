using System.Linq;

namespace Richest_Customer_Wealth
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public static int MaximumWealth(int[][] accounts)
        {
            var max = 0;
            foreach (var bank in accounts)
            {
                if (bank.Sum() > max) max = bank.Sum();
            }

            return max;
        }
    }
}