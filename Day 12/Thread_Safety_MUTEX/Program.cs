using System;
namespace Thread_Safety_Mutex
{
    public class MainClass
    {
        private static Mutex mutex = new Mutex();
        public static void Main(String[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(MutexControl);
                t.Name = "Thread " + i;
                t.Start();
            }
            Console.ReadKey();
        }
        public static void MutexControl()
        {

            Console.WriteLine($"The Thread {Thread.CurrentThread.Name} wants to enter into the critical section");
            try
            {
                mutex.WaitOne();
                Console.WriteLine($"The Thread {Thread.CurrentThread.Name} is processing");
                Thread.Sleep(3000);
                Console.WriteLine($"The Thread {Thread.CurrentThread.Name} is finished");
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
