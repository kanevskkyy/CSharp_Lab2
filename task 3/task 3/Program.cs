using System;

class Task
{
    static void Main()
    {
        int size;
        Console.Write("Enter size of array (this size we will multiply by 4 automatically) = ");
        size = int.Parse(Console.ReadLine());
        int[] array = new int[size * 4];
        int[] result = new int[size * 2];
        size *= 4;

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter {i + 1} element = ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] first_subarray = new int[size / 2];
        int counter_for_first = 0;
        for (int i = (size / 4) - 1; i >= 0; i--)
        {
            first_subarray[counter_for_first] = array[i];
            counter_for_first++;
        }
        for (int i = size - 1; i >= 3 * size / 4; i--)
        {
            first_subarray[counter_for_first] = array[i];
            counter_for_first++;
        }
        int counter = 0;
        for (int i = size / 4; i < 3 * size / 4; i++)
        {
            result[counter] = first_subarray[counter] + array[i];
            counter++;
        }
        line();
        Console.Write("Result = ");
        for (int i = 0; i < counter; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
