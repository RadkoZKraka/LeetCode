namespace Number_of_Steps_to_Reduce_a_Number_to_Zero
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
        public int NumberOfSteps(int num)
        {
            if (num == 0) return 0;
            var steps = 0;
            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    steps++;
                    continue;
                }

                num -= 1;
                steps++;
            }

            return steps;
        }
    }
}