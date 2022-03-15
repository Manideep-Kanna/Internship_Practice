using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_App
{
    class CustomerList : Product
    {
        public delegate void MyEvent();
        public event MyEvent message;
        public List<Customer> customerList = new List<Customer>();//make a customer list
        public void Attach(Customer cust) //add customer
        {
            Console.WriteLine("The customer is added");
            customerList.Add(cust);
        }
        public void Detach(Customer cust) //remove customer from pattern
        {
            customerList.Remove(cust);
        }
        public void NotifyMe(string display) //making a notifier to notify the customers
        {
            if (message != null)
            {
                message.Invoke();
                Console.WriteLine(display);


            }


        }

    }
}
