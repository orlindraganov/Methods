using System;


class AppearanceCount
{
    static int CountAppearance(int[] arr, int num)
    {
        int counter = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        int[] arr = new int[arraySize];
        string[] numbers = Console.ReadLine().Split(' ');
        int numberToCheck = int.Parse(Console.ReadLine());
        for (int i = 0; i < arraySize; i++)
        {
            arr[i] = int.Parse(numbers[i]);
        }
        int counter = CountAppearance(arr, numberToCheck);
        Console.WriteLine(counter);

    }
}
