using System;

namespace CSharpFundamentalsOne
{
    class Program
    {
        static void Main (string[] args)
        {
            // #1
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine (i);
            }

            // #2
            for (int j = 0; j <= 100; j++)
            {
                if (j % 3 == 0 || j % 5 == 0)
                {
                    if (!(j % 3 == 0 && j % 5 == 0))
                    {
                        Console.WriteLine (j);
                    }

                }
            }

            // #3
            for (int k = 0; k <= 100; k++)
            {
                if ((k % 3 == 0) && (k % 5 != 0))
                {
                    Console.WriteLine ("Fizz");
                }
                if ((k % 3 != 0) && (k % 5 == 0))
                {
                    Console.WriteLine ("Buzz");
                }
                if ((k % 3 == 0) && (k % 5 == 0))
                {
                    Console.WriteLine ("FizzBuzz");
                }
            }

            // #4
            int l = 1;
            while (l <= 100)
            {
                if ((l % 3 == 0) && (l % 5 != 0))
                {
                    Console.WriteLine ("Fizz");
                }
                if ((l % 3 != 0) && (l % 5 == 0))
                {
                    Console.WriteLine ("Buzz");
                }
                if ((l % 3 == 0) && (l % 5 == 0))
                {
                    Console.WriteLine ("FizzBuzz");
                }

                l++;
            }

        }
    }
}