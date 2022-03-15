using System;
using System.Reflection;

namespace Perfect_Reflection { 
class Perfect_Reflection
    {
       public static void Main(String[] args)
        {
            Type T = Type.GetType("Perfect_Reflection.Customer");
            Console.WriteLine("The full name of the class is {0}",T.FullName);
            Console.WriteLine("The name of the class is {0}",T.Name);
            Console.WriteLine("The namespace of the class is {0}", T.Namespace);
            Console.WriteLine("Properties in the customers");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties) {
                Console.WriteLine(property.PropertyType.Name +" "+property.Name);
            }
            Console.WriteLine("Methods in the customers");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name+" "+method.Name);
            }
            Console.WriteLine("Constructors in the customers");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
    public class Customer { 
   public int id { get; set; }
   public string name { get; set; }
   public Customer(int id,string name)
        {
            this.id = id;   
            this.name = name;
        }
    public Customer()
        {
            this.id = -1;
            this.name =string.Empty;
        }
        public void PrindId()
        {
            Console.WriteLine("The Id of the customer is {0}", id);
        }
        public void PrintName()
        {
            Console.WriteLine($"The Name of the customer is {name}");
        }
    }

}