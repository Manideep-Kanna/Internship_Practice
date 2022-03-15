using System;
using System.Threading;
namespace Thread_Basics
{
    public class MainClass {

        static bool iscompleted;
        static readonly object lockCompleted=new object();
        public static void Main(string[] args)
        {
            Thread thread = new Thread(HelloWorld);
            thread.Start();
            HelloWorld();

        }
        public static void HelloWorld()
        {
            lock (lockCompleted)
            {
                if (!iscompleted)
                {
                   
                    Console.WriteLine("Hello World");
                    iscompleted = true;

                }
            }
        }
    
    }
}