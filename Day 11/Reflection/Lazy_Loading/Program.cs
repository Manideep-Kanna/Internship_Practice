using System;
using System.Reflection;
namespace Kanna
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType("Kanna.Customer");
            object obj= Activator.CreateInstance(type);
            MethodInfo function = type.GetMethod("FullName");
            string[]paramaters=new string[2];
            paramaters[0] = "Manideep";
            paramaters[1] = "Kanna";
            string fullname=(string)function.Invoke(obj, paramaters);
            Console.WriteLine(fullname);

        }
    }
    public class Customer { 
    public string FullName(string first_name,string second_name)
        {
            return first_name + second_name;
        }
    }
}