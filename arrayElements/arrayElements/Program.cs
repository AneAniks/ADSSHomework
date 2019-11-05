using System;

namespace arrayElements
{
    class Program
    {
        public static int[] CountPsSumNeg(int[] input)
        {
            int count = 0, sum = 0;

            if ( input == null || input.Length == 0 )
            {
                return new int[] { };
            }

            for( int i=0; i < input.Length; i++ )
            {
                if( input[i] > 0 )
                {
                    count = count + 1;
                }
                if( input[i] < 0 )
                {
                    sum = sum + input[i];
                }
            }
                return new int[] { count, sum };
        } 
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            string leng;
            int lengNum;
            int[] result = new int[2];

            //int[] result = CountPsSumNeg(arr);

            //Console.WriteLine(" Result: [" + result[0] + ", " + result[1] + "] ");

            Console.Write("Enter size of the array: ");

            leng = Console.ReadLine();
            lengNum = int.Parse(leng);

            int[] input = new int[lengNum];

            Console.WriteLine("Input elements in the array: ");

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Convert.ToInt32(Console.ReadLine());

                result = CountPsSumNeg(input);
            }

            Console.WriteLine(" Result: [" + result[0] + ", " + result[1] + "] ");
        }
    }
}
