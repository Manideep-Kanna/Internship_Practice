using System;
namespace Generics
{
    public class main
    {
        public static void Main(String[] args)
        {
            //Generic Object 
            var obj=new Generic<string>();
            obj.Name = "Manideep";
            Console.WriteLine(obj.Name);
            //Non Generic Object
            var obj1 = new NonGeneric();
            obj1.PrintName<string>("Kanna");
            
        }
    }
    //An generic class can have generic functions 
    public class Generic<Kanna>
    {
        public Kanna Name { get; set; }

    }
    //An non generic classes can also have generic funcitons
    public class NonGeneric {
        public void PrintName<T>(T Name)
        {
            Console.WriteLine(Name);
        }
    
    }

}
