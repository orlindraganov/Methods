using System;
using System.Linq;
using System.Text;
using System.Numerics;

class NFactorial
{
    static int[] GetArray()
    {
        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(s => int.Parse(s)).ToArray();
        return arr;
    }

    static BigInteger Multiply(BigInteger first, BigInteger second)
    {
        BigInteger result = first * second;
        return result;
    }

    static BigInteger Factorial(int[] arr, int pos = 0)
    {
        BigInteger result = 1;
        if (pos < arr.Length)
        {
            result = Multiply(arr[pos], Factorial(arr, pos + 1));
        }
        return result;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] arr = new int[number];
        for (int i = 0; i < number; i++)
        {
            arr[i] = i + 1;
        }
        BigInteger result = Factorial(arr);
        Console.WriteLine(result);
    }
}