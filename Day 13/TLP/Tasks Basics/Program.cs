using System;
using System.Threading;
namespace Basics
{
    public class Basics
    {

        public static void Main(String[] args)
        {
            //Traditional Way of creating Tasks
            Task t1 = new Task(Task1);
            Task t2 = new Task(Task2);
            t1.Start();
            t2.Start();

            //create and start at a time in Tasks
            Task t3 = Task.Factory.StartNew(Task1);
            Task t4 = Task.Factory.StartNew(Task2);

            //Using the Run Method
            Task t5 = Task.Run(() => { Task1(); });
            Task t6 = Task.Run(() => { Task2(); });

            Console.ReadKey();

        }
        static void Task1()
        {
            Console.WriteLine("This is Task1");
        }
        static void Task2()
        {
            Console.WriteLine("This is Task2");
        }

    }
}
