using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Class
    {
         string name;
        public String Name { get { return name; } set { name = value; } }
        public void print()
        {
            Console.WriteLine($"Hey {Name} this is Class print function how are you");
        }
       public static class NestedClass
        {
            public void print()
            {
                Console.WriteLine("This is the nested class print");
            }
        }
    }
}
