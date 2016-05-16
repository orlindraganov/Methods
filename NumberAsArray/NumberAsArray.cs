using System;
using System.Linq;
using System.Text;

class NumberAsArray
{
    static int[] GetArray()
    {
        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(s => int.Parse(s)).ToArray();
        return arr;
    }

    static int[] AddArrays(int[] firstArray, int[] secondArray)
    {
        int resultSize = Math.Max(firstArray.Length, secondArray.Length) + 1;
        bool carry = false;
        int[] result = new int[resultSize];
        for (int i = 0; i < resultSize; i++)
        {
            if (firstArray.Length > i && secondArray.Length > i)
            {
                result[i] = firstArray[i] + secondArray[i];
            }
            else if (firstArray.Length > i)
            {
                result[i] = firstArray[i];
            }
            else if (secondArray.Length > i)
            {
                result[i] = secondArray[i];
            }
            else
            {
                result[i] = 0;
            }
            if (carry)
            {
                result[i] += 1;
                carry = false;
            }
            if (result[i] >= 10)
            {
                result[i] = result[i] % 10;
                carry = true;
            }
        }
        return result;
    }

    static string ArrToStr(int[] input)
    {
        StringBuilder convertToString = new StringBuilder(input.Length * 2 - 1);

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1)
            {
                convertToString.Append(input[i]);
                convertToString.Append(' ');
            }
            else if (input[i] != 0)
            {
                convertToString.Append(input[i]);
            }
            else
            {
                break;
            }
        }
        return convertToString.ToString();
    }


    static void Main(string[] args)
    {
        int[] arrsize = GetArray();

        int[] firstNumber = GetArray();

        int[] secondNumber = GetArray();

        int[] result = AddArrays(firstNumber, secondNumber);

        Console.WriteLine(ArrToStr(result));
    }
}