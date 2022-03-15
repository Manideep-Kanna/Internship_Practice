using System;
namespace SingleTon { 
class SingleTon
    {
        class Printer
        {
            static Printer _obj;
            Printer() { }
            public static Printer Instance()
            {
                if (_obj == null)
                {
                    _obj = new Printer();
                }
                 return _obj;
            }
        }
        public static void Main(String[]args)
        {
           var Task1=Printer.Instance();
           var Task2=Printer.Instance();
           Console.WriteLine(Task1.GetHashCode());
           Console.WriteLine(Task2.GetHashCode());


        }
    }

}