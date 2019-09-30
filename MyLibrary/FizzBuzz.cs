using System;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class FizzBuzz
    {
        private int[] _numbers = null;

        public int[] Numbrers {
            get
            {
                if(_numbers != null)
                    return _numbers;
                return new int[0];
            }
        }

        public FizzBuzz(int length)
        {
            _numbers = new int[length];
            Random random = new Random();
            for(int i = 0; i < length; i++)
            {
                int tmpNumber = random.Next(1, 1000);
                if (_numbers.Equals(tmpNumber)){
                    tmpNumber = random.Next(1, 1000);
                }
                _numbers[i] = tmpNumber;
            }
        }

        public void FizzBuzzSearch(int multiplier1, int multiplier2)
        {
            foreach(var a in _numbers)
            {
                if(a % multiplier1 == 0 && a % multiplier2 == 0)
                {
                    Console.WriteLine($"{a} FizzBuzz");
                }
                else if (a % multiplier1 == 0)
                {
                    Console.WriteLine($"{a} Fizz");
                }
                else if (a % multiplier2 == 0)
                {
                    Console.WriteLine($"{a} Buzz");
                }
            }
        }

        public async Task<string> AsyncFizzBuzzSearch(int multiplier1, int multiplier2)
        {
            int dividedStart = 0;
            int dividedEnd = _numbers.Length / 10;
            do
            {
                await Calculation(dividedStart, dividedEnd, multiplier1, multiplier2);
                dividedStart = dividedEnd;
                dividedEnd += dividedStart;
                if (dividedEnd > _numbers.Length)
                {
                    dividedEnd = _numbers.Length;
                }
            }
            while (dividedStart < _numbers.Length);
            return "Done";
        }

        public async Task Calculation(int start, int end, int multiplier1, int multiplier2)
        {
            await Task.Run(() =>
            {
                for (int i = start; i < end; i++)
                {
                    if (_numbers[i] % multiplier1 == 0 && _numbers[i] % multiplier2 == 0)
                    {
                        Console.WriteLine($"{_numbers[i]} FizzBuzz");
                    }
                    else if (_numbers[i] % multiplier1 == 0)
                    {
                        Console.WriteLine($"{_numbers[i]} Fizz");
                    }
                    else if (_numbers[i] % multiplier2 == 0)
                    {
                        Console.WriteLine($"{_numbers[i]} Buzz");
                    }
                }
            });
        }
    }
}
