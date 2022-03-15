using System;
using System.Threading;
namespace MultiThreading
{
    public class MainClass {
        public static void Main(string[] args) {
            Thread down1 = new Thread(AssasinCreed1);
            Thread down2 = new Thread(AssasinCreed2);
            down1.Start();
            down2.Start();

        }
        public static void AssasinCreed1()
        {
            Console.WriteLine("Assasin Creed 1 is downloading");
            Thread.Sleep(5000);
            Console.WriteLine("Assasin Creed 1 download is completed");
        }
        public static void AssasinCreed2()
        {
            Console.WriteLine("Assasin Creed 2 is downloading");
            Thread.Sleep(3000);
            Console.WriteLine("Assasin Creed 2 download is completed");
        }

    }
}