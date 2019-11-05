using System;

namespace CountSheeps
{
    class Program
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;
            
            foreach (bool check in sheeps)
            {
                if (check == true)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            var sheeps = new bool[] { true, true, true, false, true, true, true, true, true, false, true, false, true, false, false, true, true, true, true, true, false, false, true, true };
            var sheepsV2 = new bool[] { true, false, false, true, true, true, false, true };

            Console.Write("Number of sheeps: ");
            Console.WriteLine(CountSheeps(sheeps));

            Console.Write("Number of sheeps: ");
            Console.WriteLine(CountSheeps(sheepsV2));
        }
    }
}
