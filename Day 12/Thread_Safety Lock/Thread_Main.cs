using System;

namespace Multithreading
{
    class Program
    {
        static readonly object _object = new object();

        static void Print()
        {

            lock (_object)
            {
                Console.WriteLine($"The {Thread.CurrentThread.Name} is started executing");
                Thread.Sleep(1000);
                Console.WriteLine($"The {Thread.CurrentThread.Name} is done executing");
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(Print);
                t.Name = "Thread " + i;
                t.Start();
            }

            Console.ReadLine();
        }
    }
}