
Thread th = Thread.CurrentThread;
Console.WriteLine("The main thread is here");
Thread th2 = new Thread(ChildClassfunction);
th2.Start();
static void ChildClassfunction()
    {
        Console.WriteLine("Child thread called this funciton");
        Thread.Sleep(1000);
        Console.WriteLine("Child Thread Completed its process in {0} sec ", 7);
    }

