using System;
using System.Linq;



class FirstLargerThanNeighbours
{

    static int FirstLarger(int[] arr)
    {
        if (arr.Length > 2)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
        else
        {
            return -1;
        }
    }

    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];
        arr = Console.ReadLine()
            .Split(' ')
            .Select(s => int.Parse(s)).ToArray();
        Console.WriteLine(FirstLarger(arr));

    }
}
