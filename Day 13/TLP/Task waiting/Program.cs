using System;
namespace task_waiting
{
    public class task_waiting
    {
        public static void Main(String[] args)
        {
            ////For only one task waiting
            //var task1= Task.Run(() => { return Task1(); });
            //var awaiter1=task1.GetAwaiter();
            //awaiter1.OnCompleted(() =>
            //{
            //    var result = awaiter1.GetResult();
            //    Task.Run(() => { Task2(result); });

            //});
            var task3 = Task.Run(() => { return Task3(); });
            var task4 = Task.Run(() => { return Task4(); });
            Task.WaitAll(task3,task4);
            var awaiter1=task3.GetAwaiter();
            var awaiter2=task3.GetAwaiter();
            int res1=awaiter1.GetResult();
            int res2=awaiter2.GetResult();
            Task.Run(() => { Task5(res1,res2); });

            Console.ReadKey();

        }
        public static int Task1()
        {
            int count = 0;
            for(int i = 0; i < 10; i++)
            {
                count++;
            }
            return count;
        }
        public static void Task2(int count)
        {
            Console.WriteLine("The number came from the task{0}", count);
        }
        public static int Task3()
        {
            return 100;
        }
        public static int Task4()
        {
            return 200;
        }
        public static void Task5(int res1,int res2)
        {
            Console.WriteLine(res2);
            Console.WriteLine("I got the {0} and {1} as the input ", res1, res2);
        }

    }
}