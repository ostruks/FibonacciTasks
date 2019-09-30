using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    public class SingletonExample
    {
        private static SingletonExample _instanse;
        private static object _syncObject = new object();

        private SingletonExample()
        {
            Console.WriteLine($"SingletonExample {DateTime.Now.Ticks}");
        }

        public static SingletonExample GetInstanse
        {
            get
            {
                lock (_syncObject)
                {
                    if (_instanse == null)
                    {
                        _instanse = new SingletonExample();
                    }
                }
                
                return _instanse;
            }
        }

        public async Task<int> Sum(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine("AsyncSimulation run");
            await AsyncSimulation(sum);
            Console.WriteLine("AsyncSimulation complited");

            return a + b;
        }

        private async Task AsyncSimulation(int delay)
        {
            Console.WriteLine("AsyncSimulation");
            await Task.Run(() => { Thread.Sleep(delay * 100); });
        }
    }
}
