using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[,] array = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = rnd.Next(-100, 101);
                Console.Write($"{array[i, j],5}");
            }
            Console.WriteLine();
        }

        int min = array[0, 0];
        int max = array[0, 0];

        int minPos = 0;
        int maxPos = 0;

        int index = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minPos = index;
                }

                if (array[i, j] > max)
                {
                    max = array[i, j];
                    maxPos = index;
                }

                index++;
            }
        }

        if (minPos > maxPos)
        {
            int temp = minPos;
            minPos = maxPos;
            maxPos = temp;
        }

        int sum = 0;
        index = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (index > minPos && index < maxPos)
                {
                    sum += array[i, j];
                }
                index++;
            }
        }

        Console.WriteLine($"\nMin: {min}");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Sum between them: {sum}");
    }
}
