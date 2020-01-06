using System;

namespace ProjectEuler
{
    class Program
    {
        static void ProblemOne()
        {
            int sum = 0;

            for (int i = 0; i<1000; i++)
            {
                if ( i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Problem 1: {sum}");
        }


        static void Main(string[] args)
        {
            ProblemOne();
        }
    }
}
