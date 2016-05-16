using System;
using System.Text;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        string decimalNumber = Console.ReadLine();
        Console.WriteLine(Reverse(decimalNumber));
    }

    static string Reverse(string toReverse)
    {
        StringBuilder reverser = new StringBuilder(toReverse.Length);
        for (int i = 0; i < toReverse.Length; i++)
        {
            reverser.Append(toReverse[toReverse.Length - 1 - i]);
        }
        return reverser.ToString();
    }
}