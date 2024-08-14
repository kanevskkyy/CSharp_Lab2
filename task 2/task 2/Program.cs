using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of array = ");
        int size = int.Parse(Console.ReadLine());

        Console.Write("Enter amount of revs = ");
        int amount_revs = int.Parse(Console.ReadLine());

        int[] start_array = new int[size];
        int[] array_of_sum = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter {i + 1} element in array = ");
            start_array[i] = int.Parse(Console.ReadLine());
            array_of_sum[i] = 0;
        }
        int[] temp_array = new int[size];

        int counter = 1;
        for (int rev = 0; rev < amount_revs; rev++)
        {
            for (int i = 0; i < size; i++)
            {
                temp_array[(i + 1) % size] = start_array[i];
            }
            for (int i = 0; i < size; i++)
            {
                array_of_sum[i] += temp_array[i];
            }
            Console.Write($"rotated[{counter}] = ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(temp_array[i] + " ");
            }
            Console.WriteLine();
            counter++;
            Array.Copy(temp_array, start_array, size);
        }
        Console.Write("sum[] = ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array_of_sum[i] + " ");
        }
    }
}
