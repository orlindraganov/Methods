using System;
using System.Linq;
using System.Numerics;

class IntegerCalculations
{
    static int[] GetArray()
    {
        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(s => int.Parse(s)).ToArray();
        return arr;
    }

    static double FindAverage(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        double average = Math.Round(sum / (double)arr.Length, 2);
        return average;
    }

    static int FindSum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static BigInteger FindProduct(int[] arr)
    {
        BigInteger product = 1;
        foreach (int member in arr)
        {
            product *= member;
        }
        return product;
    }


    static int FindMax(int[] arr)
    {
        int max = int.MinValue;
        foreach (int member in arr)
        {
            if (member > max)
            {
                max = member;
            }
        }
        return max;
    }

    static int FindMin(int[] arr)
    {
        int min = int.MaxValue;
        foreach (int member in arr)
        {
            if (member < min)
            {
                min = member;
            }
        }
        return min;
    }

    static void Main()
    {
        int[] arr = GetArray();
        Console.WriteLine(FindMin(arr));
        Console.WriteLine(FindMax(arr));
        Console.WriteLine("{0:F2}", FindAverage(arr));
        Console.WriteLine(FindSum(arr));
        Console.WriteLine(FindProduct(arr));

    }
}
