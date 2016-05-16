using System;
using System.Linq;
using System.Text;

class AddingPolynomials
{
    static int[] GetArray()
    {
        int[] arr = Console.ReadLine()
            .Split(' ')
            .Select(s => int.Parse(s)).ToArray();
        return arr;
    }

    static int[] SubstractPolynomials(int[] first, int[] second, int length)
    {
        for (int i = 0; i < length; i++)
        {
            first[i] -= second[i];
        }
        return first;
    }

    static string ConvertArrayToString(int[] arr)
    {
        StringBuilder arrToString = new StringBuilder(arr.Length * 2);
        for (int i = 0; i < arr.Length; i++)
        {
            arrToString.Append(arr[i]);
            arrToString.Append(' ');
        }
        return arrToString.ToString().Trim();
    }


    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] firstPolynomial = GetArray();
        int[] secondPolynomial = GetArray();

        Console.WriteLine(ConvertArrayToString(SubstractPolynomials(firstPolynomial, secondPolynomial, number)));


    }
}
