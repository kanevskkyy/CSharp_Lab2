using System;

class Program
{
    static void Main()
    {
        string[] array1 = { "hi", "php", "java", "csharp", "sql", "html", "css", "js" };
        string[] array2 = { "hi", "php", "java", "js", "softuni", "nakov", "java", "learn" };
        int min_length = Math.Min(array1.Length, array2.Length);
        int counter_for_left = 0;
        for (int i = 0; i < min_length; i++)
        {
            if (array1[i] == array2[i])
            {
                counter_for_left++;
            }
            else
            {
                break;
            }
        }
        int counter_for_right = 0;
        for (int i = 1; i <= min_length; i++)
        {
            if (array1[array1.Length - i] == array2[array2.Length - i])
            {
                counter_for_right++;
            }
            else
            {
                break;
            }
        }

        if (counter_for_left == 0 || counter_for_right == 0)
        {
            Console.WriteLine("There is no matches");
            return;
        }

        string[] resultArray;
        if (counter_for_left > counter_for_right)
        {
            Console.WriteLine("The longest length is on the left");
            resultArray = new string[counter_for_left];
            for (int i = 0; i < counter_for_left; i++)
            {
                resultArray[i] = array1[i];
                Console.Write(resultArray[i]);
                Console.Write(" ");
            }
        }
        else if (counter_for_right > counter_for_left)
        {
            Console.WriteLine("The longest length is on the right");
            resultArray = new string[counter_for_right];
            for (int i = 0; i < counter_for_right; i++)
            {
                resultArray[i] = array1[array1.Length - counter_for_right + i];
                Console.Write(resultArray[i]);
                Console.Write(" ");
            }
        }
    }
}
