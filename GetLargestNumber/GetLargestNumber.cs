using System;



class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }


    static void Main()
    {
        int largest = int.MinValue;

        string[] input = Console.ReadLine().Split(' ');

        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
            largest = GetMax(largest, numbers[i]);
        }

        Console.WriteLine(largest);
    }
}
