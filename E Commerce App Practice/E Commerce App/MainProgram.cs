using E_Commerce_Website;
using E_Comm_Cust;
namespace E_Commerce_App
{
    internal class MainProgram
    {
        public delegate void SubscriberDelegate();
        public static void Main(string[] args)
        {
            //Variable no of customers
            List<Customer> cust = new List<Customer>();
            Customer cust1 = new Customer("Kanna");
            Customer cust2 = new Customer("Manideep");
            cust.Add(cust1);
            cust.Add(cust2);
            //Ecommerce website
            Ecomm_Website website = new Ecomm_Website();
            //Notification instance
            Notification notification = new Notification();
            for (int i = 0; i < cust.Count; i++) {
                string req_productName;
                //Enter the details for the product 
                Console.WriteLine("Please Enter that product you are looking for ");
                req_productName = Console.ReadLine();
                //Calling the website to check if the product is available 
                string req_product_info_json = website.find(req_productName);
                if (req_product_info_json != null)//if available then return json string
                {
                    Console.WriteLine(req_product_info_json);
                }
                else
                {
                    Console.WriteLine("There is no product available for now we will notify you once we get that item");
                 //if the product is not available add the customer to subscriber list
                    notification.Notification_Add(cust[i]);
                }

            }
            //Admin tryinig to add the product 
            website.AddProduct(notification);

        }
    }
}
