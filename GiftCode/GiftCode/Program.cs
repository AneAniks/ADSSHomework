using System;

namespace GiftCode
{
    class Program
    {
        public static string SortGiftCode(string giftCode)
        {
            char[] chars = new char[giftCode.Length];
            string result = "";

            for (int i = 0; i < giftCode.Length; i++)
            {
                chars[i] = giftCode[i];
            }

            Array.Sort(chars);

            for (int i = 0; i < giftCode.Length; i++)
            {
                result += chars[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input;

            Console.Write("Enter string: ");
            input = Console.ReadLine();

            Console.Write("Sorted string: ");
            Console.WriteLine(SortGiftCode(input));
        }
    }
}
