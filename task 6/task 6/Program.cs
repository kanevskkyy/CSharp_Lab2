using System;

class Task
{
    static void Main()
    {
        Console.Write("Enter size of array = ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter {i + 1} element = ");
            array[i] = int.Parse(Console.ReadLine());
        }
        line();

        int max_length = 0;
        int current_length = 1;
        int max_start_index = 0;
        for (int i = 1; i < size; i++)
        {
            if (array[i] == array[i - 1])
            {
                current_length++;
            }
            else
            {
                if (current_length > max_length)
                {
                    max_length = current_length;
                    max_start_index = i - current_length;
                }
                current_length = 1;
            }
        }
        if (current_length > max_length)
        {
            max_length = current_length;
            max_start_index = size - current_length;
        }
        for (int i = max_start_index; i < max_start_index + max_length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
