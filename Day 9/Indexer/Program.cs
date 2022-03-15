using System;
namespace Indexer
{
    class User
    {
     
        public static void Main(String[] args)
        {
           Customer customer = new Customer();
            Console.WriteLine("Normal Funciton");
            Address address=customer.GetAddress(5051);
            Console.WriteLine(address._state);
            Console.WriteLine("This is indexer Adda");
           Address address1= customer[5052];
            Console.WriteLine(address1._state);

        }

    }
    }
