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
                        Console.WriteLine("This is the error you are getting \n " + e.Message);
                    }
                });
                t.Wait();
                Console.Read();
        }
    
    }
}