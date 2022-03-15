using System;
namespace Generic_Delegates
{/*There are total three types of Generic Delegates
   1.Func<input,ouput> used when a function having any return type
   2.Action<input> used when a function not having any return type
   3.Predicate<input>used when a function is having bool Func delegate can also be used

  
  */
    public  class Generic_Delegates
    {
        public static void Main(String[] args)
        {
            Func<int, int, int> obj1 = Add;
            Action<int, int> obj2 = Multiply;
            Predicate<int> obj3 = Check;
            Console.WriteLine(obj1(10, 30));
            obj2(10, 30);
            Console.WriteLine(obj3(10));
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }
        public static void Multiply(int x,int y)
        {
            Console.WriteLine(x*y);
        }
        public static bool Check(int x)
        {
            if (x == 0) return false;
            else return true;
        }
    }
}
