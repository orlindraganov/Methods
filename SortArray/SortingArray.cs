using System;
using System.Linq;
using System.Text;

class SortingArray
{
    static int[] GetArray()
    {
        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(s => int.Parse(s)).ToArray();
        return arr;
    }

    static string ArrToStr(int[] input)
    {
        StringBuilder convertToString = new StringBuilder(input.Length * 2 - 1);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (i > 0)
            {
                convertToString.Append(input[i]);
                convertToString.Append(' ');
            }
            else
            {
                convertToString.Append(input[i]);
            }
        }
        return convertToString.ToString();
    }

    static int[] SortArray(int[] input, int start = 0)
    {
        if (start == input.Length - 1)
        {
            return input;
        }
        int max = input[start];
        int temp = input[start];

        for (int i = start; i < input.Length; i++)
        {
            if (input[i] > max)
            {
                max = input[i];
                input[i] = input[start];
                input[start] = max;
            }
        }
        SortArray(input, start + 1);
        return input;
    }

    static void Main(string[] args)
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = GetArray();
        arr = SortArray(arr);
        Console.WriteLine(ArrToStr(arr));
    }
}
