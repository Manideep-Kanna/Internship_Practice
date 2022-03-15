
namespace E_Comm_Cust{
   
    public class Customer
    {
         string _name;
        public string Name { get { return _name; }  }
        public Customer(string name)
        {
            _name = name;
        }
        public void objEventAdded()//Event for each customer(Subscriber)
        {
            Console.WriteLine($"{this.Name} Your product is available ");

        }
    }


}