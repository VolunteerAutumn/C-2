using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10];
        Console.WriteLine("Enter the numbers to add to the array A > ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{i + 1}: ");
            string input = Console.ReadLine().Replace(',', '.');
            array[i] = int.Parse(input);
        }
        int amount = 0;
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        int min = max;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - min) == 5)
            {
                amount++;
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]}");
        }

        Console.WriteLine($"There are {amount} elements different from the minimal by 5 in the array.");
    }
}
