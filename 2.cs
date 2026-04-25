namespace epstein_files_csharp_edition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            // randomly filling the array with numbers from 0 to 9
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }
            int val = int.Parse(Console.ReadLine());
            int amount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < val)
                {
                    amount++;
                }
            }
            Console.WriteLine($"There are {amount} numbers in the array that are less than {val}.");
        }
    }
}
