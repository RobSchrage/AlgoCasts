using System;
using System.Linq;

namespace Main.completed_exercises.fizzbuzz
{
    public class FizzBuzz
    {
        public void Execute(int numCount)
        {
            foreach (var num in Enumerable.Range(1, numCount))
            {
                if (num % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
