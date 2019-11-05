using System;

namespace BinaryAddition
{
    class Program
    {
        public static string AddBinary(int a, int b)
        {
            int sum = a + b;
            string binaryString = Convert.ToString(sum, 2);

            return binaryString;
        }
        static void Main(string[] args)
        {
            string input;
            int a, b;

            Console.Write("Enter first number: ");
            input = Console.ReadLine();
            a = int.Parse(input);

            Console.Write("Enter second number: ");
            input = Console.ReadLine();
            b = int.Parse(input);

            Console.Write("Binatry format: ");
            Console.WriteLine(AddBinary(a, b));

        }
    }
}
