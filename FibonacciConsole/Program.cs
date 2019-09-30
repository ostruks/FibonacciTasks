using MyLibrary;
using System;
using System.Diagnostics;

namespace FibonacciConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci:");
            Console.WriteLine(Fibonacci.FibonacciNumbers(3));
            Fibonacci.Numbers.Insert(0, 1);

            foreach (var a in Fibonacci.Numbers)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            Console.WriteLine("========================");

            FizzBuzz fizzBuzz = new FizzBuzz(1000);
            Stopwatch watch = new Stopwatch();

            Console.WriteLine("FizzBuzz:");
            watch.Start();
            Console.WriteLine("Start!");
            fizzBuzz.FizzBuzzSearch(3, 11);
            Console.WriteLine("End");
            watch.Stop();

            Console.WriteLine("========================");
            Console.WriteLine(watch.Elapsed.ToString());
            Console.WriteLine("========================");

            Console.WriteLine("FizzBuzzAsync:");
            watch.Start();
            Console.WriteLine("Start!");
            var task = fizzBuzz.AsyncFizzBuzzSearch(3, 11);
            Console.WriteLine(task.Result);
            Console.WriteLine("End");
            watch.Stop();

            Console.WriteLine("========================");
            Console.WriteLine(watch.Elapsed.ToString());
            Console.WriteLine("========================");

            Console.ReadKey();
        }
    }
}
