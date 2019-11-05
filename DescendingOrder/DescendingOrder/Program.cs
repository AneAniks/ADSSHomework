using System;

namespace DescendingOrder
{
    class Program
    {
        public static int DescendingOrder(int num)
        {
            int[] arr = new int[10];
            int result = 0;
            int position = 1;

            while (num > 0)
            {
                int mod = num % 10;
                num = num / 10;
                arr[mod]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr[i]; j > 0; j--)
                {
                    result = result + (i * position);
                    position *= 10;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string input;
            int num;
            input = Console.ReadLine();
            num = int.Parse(input);

            Console.Write("Highest possible number is: ");
            Console.WriteLine(DescendingOrder(num));
        }
    }
}
