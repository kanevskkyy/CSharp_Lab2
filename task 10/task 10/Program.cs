using System;

class Task
{
    static void Main()
    {
        Console.Write("Enter size of array = ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        line();
        for(int i=0;i< size; i++)
        {
            Console.Write($"Enter {i + 1} element of array = ");
            array[i] = int.Parse(Console.ReadLine());
        }
        line();
        Console.Write("Enter a difference you want to find = ");
        int difference = int.Parse(Console.ReadLine());
        int counter = 0;
        line();

        for(int i = 0; i < size; i++)
        {
            for(int j = i + 1; j < size; j++)
            {
                if(Math.Abs(array[i] - array[j]) == difference)
                {
                    counter++;
                }
            }
        }
        if (counter == 0) Console.WriteLine($"There is no elements with difference {difference}");
        else
        {
            Console.Write($"Pairs of element if difference {difference} : ");
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (Math.Abs(array[i] - array[j]) == difference)
                    {
                        Console.Write($"({array[i]}, {array[j]}) ");
                    }
                }
            }
        }

    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
