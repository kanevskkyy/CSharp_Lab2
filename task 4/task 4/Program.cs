using System;
using System.Globalization;

class Task
{
    static void Main()
    {
        Console.Write("Enter your N = ");
        int n = int.Parse(Console.ReadLine());
        line();
        bool[] isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        for (int p = 2; p * p <= n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }
        Console.Write("Result = ");
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
            }
        }
    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
