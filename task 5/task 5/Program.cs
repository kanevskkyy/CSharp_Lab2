using System;

class Task
{
    static void Main()
    {
        char[] first_array = new char[] { 'a', 'b', 'c' };
        char[] second_array = new char[] { 'a', 'b', 'd' };

        int less_length = Math.Min(first_array.Length, second_array.Length);
        int counter = 0;

        for (int i = 0; i < less_length; i++)
        {
            if (first_array[i] < second_array[i])
            {
                print_array(first_array);
                print_array(second_array);
                return;
            }
            else if (first_array[i] > second_array[i])
            {
                print_array(second_array);
                print_array(first_array);
                return;
            }
            else
            {
                counter++;
            }
        }
        if (counter == less_length)
        {
            if (first_array.Length < second_array.Length)
            {
                print_array(first_array);
                print_array(second_array);
            }
            else
            {
                print_array(second_array);
                print_array(first_array);
            }
        }
    }
    static void print_array(char[] array)
    {
        foreach (char symbol in array)
        {
            Console.Write(symbol);
            Console.WriteLine();
        }
    }
}
