using System;

namespace TaskLibrary
{
    class Program
    {


        static void Main(string[] args)
        {
            CalculateTL calc = new CalculateTL();
            calc.calculate();
            Console.ReadLine();

            Task t1 = Task.Factory.StartNew(() => Task1());
            Task t2 = Task.Factory.StartNew(() => Task2()).ContinueWith((x) => Task1());
            Console.ReadLine();

        }

        static void Task1()
        {
            Thread.Sleep(500);
        }

        static void Task2()
        {
        }
    }
}