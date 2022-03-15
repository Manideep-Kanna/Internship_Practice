using System;
namespace Ecommerce_App
{

    public class Customer {

        public static void Main(string[] args)
        {
            string req_productName;
            //Details of the product which a customer needs
            Console.WriteLine("Please Enter that product you are looking for ");
            req_productName = Console.ReadLine();
            //Calling the factory to check if the product is available or not
            Factory factory=new Factory();
            Product req_product;
            

            if (factory.find(req_productName)!=null)
            {
                //If product is available display the details of the product
                req_product = factory.find(req_productName);
                serailize_Product serailize_Product = new serailize_Product();
                serailize_Product.Serialize_Product(req_product);
            }
            else
            {
                //If product is not available subscrber to be added
                Console.WriteLine("There is no such products in our app");
                Console.WriteLine("We will  notify you when that product will be available");
                //Subscriber is Added
                CustomerList customerlist = new CustomerList();
                customerlist.Attach(new Customer());
            }
            

        }

    }



}