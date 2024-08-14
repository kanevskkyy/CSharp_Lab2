using System;

class Task
{
    static void Main()
    {
        Console.Write("Enter your word = ");
        string sentense = Convert.ToString(Console.ReadLine());
        line();

        string letters = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < sentense.Length; i++)
        {
            for(int j = 0; j < letters.Length; j++)
            {
                if (sentense[i] == letters[j])
                {
                    Console.WriteLine($"{sentense[i]} -> {j}");
                }
            }
        }
        line();
    }

    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
