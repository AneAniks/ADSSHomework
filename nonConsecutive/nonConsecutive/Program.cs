using System;

namespace nonConsecutive
{
    class Program
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    return arr[i + 1];
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            string leng;
            int lengNum;

            Console.Write("Enter size of the array: ");

            leng = Console.ReadLine();
            lengNum = int.Parse(leng);

            int[] input = new int[lengNum];

            Console.WriteLine("Input elements in the array: ");

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());

                // ne znaev kako na drug nacin da go ispecatam
                // ne mozev da go stornam vo variabla deka e od object type
                Console.WriteLine("First non-Consecutive number is: " + FirstNonConsecutive(input)); 
            }     
        }
    }
}
