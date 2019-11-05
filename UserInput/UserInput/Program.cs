using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;

            while (true)
            {
                Console.Write("Enter integer number: ");
                input = Console.ReadLine();
                number = int.Parse(input);

                if (number >= 10)
                {
                    Console.WriteLine("Integer greater than 10 detected!");
                    break;
                }
            }
        }
    }
}
