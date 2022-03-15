using System;
namespace Anonymous {

    public class Anonymous
    {
         delegate void Mydel(string s);
        public static void Main(String[] args)
        {
            //Normal Assignment
            Mydel obj1 = new Mydel(Print);
            obj1("Kanna");
            //Anonymous Assignment
            Mydel obj2 = delegate(string s)
            {
                Console.WriteLine(s);
            };
            obj2("Manideep");
            //Lambda Function Assignment
            Mydel obj3 = (s) => Console.WriteLine(s);
            obj3("Sitaram");
        }
        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }

}
