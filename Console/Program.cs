using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Library;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();
            Console.WriteLine("Start!");
            Console.WriteLine(Environment.NewLine);

            Task.Run(() =>
            {
                Thread.Sleep(500);

                var singleton = SingletonExample.GetInstanse;

                Console.WriteLine("async code here!");
            });

            var singleton2 = SingletonExample.GetInstanse;
            var singleton3 = SingletonExample.GetInstanse;

            var c = singleton2.Sum(2, 2);
            Console.WriteLine("Async operation launched!");
            Console.WriteLine(c.Result);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("End");

            watch.Stop();

            Console.WriteLine(watch.Elapsed.ToString());

            //массив чисел на более 1000 элементов. Фис(делится на 1-й множитель)-бас(делится на второй), фисБас(на оба)
            //постраничная обработка
            //фибаначи рекурсивно
            //вычесление золотое сечение

            Console.ReadKey();
        }
    }
}
