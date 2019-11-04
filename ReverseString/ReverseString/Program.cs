using System;

class Program
{
    public static string ReverseString(string input)
    {
        char[] a = new char[input.Length];    // in the main we input string and in this function we make char array from the string 
        int n = 0;
        for (int i = input.Length - 1; i >= 0; i--)   // loop for reverse a string 
        {
            a[n++] = input[i];
        }
        return new string(a);
    }

    static void Main()
    {
        string input;

        Console.Write("Enter string: ");
        input = Console.ReadLine();

        Console.Write("Reversed string: ");
        Console.WriteLine(ReverseString(input));
    }
}