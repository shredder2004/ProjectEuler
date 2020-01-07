using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectEulerApp app = new ProjectEulerApp();

            Console.WriteLine($"Problem 1: {app.ProblemOne()}");
            Console.WriteLine($"Problem 2: {app.ProblemTwo()}");
        }
    }
}
