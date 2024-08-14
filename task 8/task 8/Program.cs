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
        int max_occur = 0, value = 0;
        for (int i = 0; i < size; i++) 
        {
            int counter = 0;
            for (int j = 0; j < size; j++)
            {
                if (array[i] == array[j]) counter++;
            }
            if (counter > max_occur)
            {
                max_occur = counter;
                value = array[i];
            }
        }
        Console.WriteLine($"The number {value} is the most frequent (occurs {max_occur} times)");
    }

    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
