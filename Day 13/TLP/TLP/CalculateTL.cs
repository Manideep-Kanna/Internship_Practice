using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class CalculateTL
    {
        public static int calculate3()
        {
            int a = 10;
            int b = 2;
            int c = a / b;
            Thread.Sleep(10000);
            Console.WriteLine($"Division : {c}");
            return c;
        }

        public static int calculate2()
        {
            int a = 10;
            int b = 2;
            int c = a * b;
            Thread.Sleep(5000);
            Console.WriteLine($"Multiplication : {c}");
            return c;
        }

        public static int calculate1(int result1, int result2)
        {
            Console.WriteLine($"Addition: {result1 + result2}");
            return (result1 + result2);
        }

        public void calculate()
        {
            var task1 = Task.Run(() =>
            {
                return calculate3();
            });

            var task2 = Task.Run(() =>
            {
                return calculate2();
            });
            Task.WaitAll(task1, task2);
            var task1awaiter = task1.GetAwaiter();
            var task2awaiter = task2.GetAwaiter();
            var task1res = task1awaiter.GetResult();
            var task2res = task2awaiter.GetResult();
            calculate1(task1res, task2res);
        }

    }
}
