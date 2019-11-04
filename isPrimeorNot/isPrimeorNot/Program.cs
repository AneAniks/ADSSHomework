using System;

namespace isPrimeOrNot
{
    class Program
    {
        public static bool isPrimeOrNot(int num)
        {
            for( int i=2; i < num; i++ )
            {
                if ( num % i == 0 )
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string input;
            int parseNum;

            Console.Write("Enter number to check if its prime or not: ");

            input = Console.ReadLine();
            parseNum = int.Parse(input);
            
            if ( isPrimeOrNot(parseNum) )
            {
                Console.WriteLine(parseNum + " is Prime number.");
            }
            else
            {
                Console.WriteLine(parseNum + " is not Prime number.");
            }
        }
    }
}
