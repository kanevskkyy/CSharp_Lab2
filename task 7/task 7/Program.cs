using System;

class Task
{
    static void Main()
    {
        Console.Write("Enter size of array = ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        line();

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter {i + 1} element = ");
            array[i] = int.Parse(Console.ReadLine());
        }
        line();

        int start_index = 0, end_index = 0;
        int max_start = 0, max_end = 0;
        int max_length = 0;

        for (int i = 0; i < size; i++)
        {
            start_index = i;
            for (int j = i + 1; j < size; j++)
            {
                if (array[j] >= array[j - 1])  end_index = j;
                else break;
            }
            int current_length = end_index - start_index + 1;
            if (current_length > max_length)
            {
                max_length = current_length;
                max_start = start_index;
                max_end = end_index;
            }
            i = end_index; 
        }

        Console.Write("Result = ");
        for (int i = max_start; i <= max_end; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}