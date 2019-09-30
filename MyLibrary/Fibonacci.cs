using System.Collections.Generic;

namespace MyLibrary
{
    public static class Fibonacci
    {
        private static readonly List<int> _numbers = new List<int>();

        public static List<int> Numbers
        {
            get
            {
                return _numbers;
            }
        }

        public static int FibonacciNumbers(int number)
        {
            int x = number == 1 || number == 2 ? 1 : FibonacciNumbers(number - 1) + FibonacciNumbers(number - 2);
            if (!_numbers.Contains(x))
                _numbers.Add(x);
            return x;
        }
    }
}
