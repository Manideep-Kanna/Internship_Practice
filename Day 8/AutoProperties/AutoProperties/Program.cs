using System;
namespace AutoProperties
{
    class MainClass {

        public static void Main(string[] args) {
            UsedClass usedClass = new UsedClass();
            usedClass.PublicProperty = 90;
            Console.WriteLine(usedClass.PublicProperty);
        }

    }
    class UsedClass {
        public int PublicProperty { get; set; }
        public int GetterProperty { get;}
        int SetterProperty { get;set; } 
       public UsedClass() { 
        PublicProperty = 0;
        GetterProperty = 0;
        SetterProperty = 0;
        
        }

    }

}