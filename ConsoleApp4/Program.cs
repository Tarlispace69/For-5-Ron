using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = 0, signMistakes = 0, otherMistakes = 0, i = 0, passed = 0;

            Console.Write("Enter the number of test takers: ");
            tests = int.Parse(Console.ReadLine());

            //checking each tester
            for(i=0; i < tests; i++)
            {
                // receiving number and type of mistakes for each tester
                // +1 for simpler understanding
                Console.Write($"Test taker {i+1}\nEnter number of failed sign questions: ");
                signMistakes = int.Parse(Console.ReadLine());
                Console.Write("Enter other mistakes: ");
                otherMistakes = int.Parse(Console.ReadLine());

                // checking if it's a pass or fail
                if (otherMistakes > 3 || signMistakes != 0)
                {
                    Console.WriteLine("Fail");
                }
                else
                {
                    Console.WriteLine("Pass");
                    passed++;
                }
            }
            Console.WriteLine($"Passed tests: {passed}\nPercentage of passed tests: {(passed / (float)tests) * 100}%");
            Console.ReadLine();

        }
    }
}
