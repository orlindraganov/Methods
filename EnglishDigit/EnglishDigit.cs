using System;
using System.Collections.Generic;

class EnglishDigit

{
    public static readonly Dictionary<int, string> digitsAsWords = new Dictionary<int, string>
{
    { 0, "zero" },
    { 1, "one" },
    { 2, "two" },
    { 3, "three" },
    { 4, "four" },
    { 5, "five" },
    { 6, "six" },
    { 7, "seven" },
    { 8, "eight" },
    { 9, "nine" }
};

    static string SayDigit(int input)
    {
        int digitToSay = input % 10;
        return digitsAsWords[digitToSay];
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string digit = SayDigit(number);
        Console.WriteLine(digit);
    }
}
