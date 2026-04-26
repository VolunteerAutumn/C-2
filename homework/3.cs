using System;
using System.Globalization;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // arrays
        double[] A = new double[5];
        double[,] B = new double[3, 4];
        Random rnd = new Random();

        // fill A
        Console.WriteLine("Enter the numbers to add to the array A > ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"{i + 1}: ");
            string input = Console.ReadLine().Replace(',', '.');
            A[i] = double.Parse(input, CultureInfo.InvariantCulture);
        }

        // fill B with random numbers
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                B[i, j] = rnd.NextDouble() * 100;
            }
        }

        // print A
        Console.WriteLine("\nArray A:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"{A[i]:F2}; ");
        }

        Console.WriteLine("\n");

        // print B as matrix
        Console.WriteLine("Matrix B:");
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                Console.Write($"{B[i, j]:F2}\t");
            }
            Console.WriteLine();
        }

        // max & min
        double verymuchmax = A[0];
        double verymuchmin = A[0];

        // sum & product
        double sum = 0;
        double prod = 1;

        // extra sums
        double sumofevenAelements = 0;
        double sumofelementsonoddcolumnsofB = 0;

        // process A
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > verymuchmax) verymuchmax = A[i];
            if (A[i] < verymuchmin) verymuchmin = A[i];

            sum += A[i];
            prod *= A[i];

            if ((int)A[i] % 2 == 0)
                sumofevenAelements += A[i];
        }

        // process B
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                double x = B[i, j];

                if (x > verymuchmax) verymuchmax = x;
                if (x < verymuchmin) verymuchmin = x;

                sum += x;
                prod *= x;

                if (j % 2 != 0)
                    sumofelementsonoddcolumnsofB += x;
            }
        }

        // results
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Max: {verymuchmax:F2}");
        Console.WriteLine($"Min: {verymuchmin:F2}");
        Console.WriteLine($"Sum: {sum:F2}");
        Console.WriteLine($"Product: {prod:F2}");
        Console.WriteLine($"Sum of even elements in A: {sumofevenAelements:F2}");
        Console.WriteLine($"Sum of odd columns in B: {sumofelementsonoddcolumnsofB:F2}");
    }
}
