using System;
namespace Exception_Handling_Threads
{
    /// <summary>
    /// The following class handles the exceptions got from the other class
    /// </summary>
    class MainClass {
        public static void Main()
        {
                SomeOtherClass obj = new SomeOtherClass();
                //Generating the perfect square list
                obj.GenerateListOfPerfectSquareNumbers();
                 //Run Through Loop
                Task t = Task.Factory.StartNew(() => {
                    try
                    {
                        obj.IterateThroughList();
                    }
                    catch (Exception e)
                    {
                        //Exception will be caught and show the error
                        Console.WriteLine("This is the error you are getting \n " + e.Message);
                    }
                });
            //Waits untill task is finished
                t.Wait();
            //Allows us to maintain the main thread alive
                Console.Read();
        }
    
    }
}