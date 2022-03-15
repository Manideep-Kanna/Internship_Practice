using System;
using System.Reflection;
namespace Reflection { 

    public class Reflection
    {
        public static void Main(string[] args)
        {
            PropertyInfo[] propinfo = typeof(SomeClass).GetProperties();
            foreach (PropertyInfo p in propinfo)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.CanRead);
                Console.WriteLine(p.CanWrite);
                Console.WriteLine(p.GetMethod);

            }
        }
    }

}