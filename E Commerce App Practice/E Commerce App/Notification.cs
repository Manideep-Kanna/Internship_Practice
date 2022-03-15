using E_Comm_Cust;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Website
{
    public delegate void Notify();
    internal class Notification
    {
        public event Notify On;
       public void Notification_Add(Customer cust)//Adds the customer to the event
        {

            On += cust.objEventAdded;
        }
        public void Notification_Invoke()//Invokes the event
        {
            On?.Invoke();//invoke if it On is not null
        }
    }
}
