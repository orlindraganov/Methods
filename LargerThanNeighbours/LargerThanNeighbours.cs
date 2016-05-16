using System;
using System.Linq;

class LargerThanNeighbours
{
    static bool CheckIfLarger(int pos, int[] arr)
    {
        if (pos != 0 && pos != arr.Length - 1)
        {
            if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int arrSize = int.Parse(Console.ReadLine());
        int[] arr = new int[arrSize];
        arr = Console.ReadLine()
            .Split(' ')
            .Select(s => int.Parse(s)).ToArray();
        int counter = 0;
        for (int i = 0; i < arrSize; i++)
        {
            bool isLarger = CheckIfLarger(i, arr);
            if (isLarger)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
