using System.ComponentModel.DataAnnotations;

namespace epstein_files_csharp_edition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
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
            int amouq = 0; // amount of unique numbers in the array
            for (int i = 0; i < array.Length; i++)
            {
                bool isunique = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        isunique = false;
                        break;
                    }
                }
                if (isunique)
                {
                    amouq++;
                }
            }

            Console.WriteLine($"Max: {max}\nMin: {min}\nThere are {amouq} unique elements in the array.");
        }
    }
}
