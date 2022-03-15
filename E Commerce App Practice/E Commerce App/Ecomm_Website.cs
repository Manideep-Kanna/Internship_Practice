using Newtonsoft.Json;
using E_Comm_Cust;
namespace E_Commerce_Website
{
   
    internal class Ecomm_Website
    {
        List<Product>products = new List<Product>();//List of products available
        HashSet<string>cust_req_list=new HashSet<string>();//list of products which customer required are not available
        
        //Constructor that add default products to the product list
        public  Ecomm_Website()
        {
            Product product1 = new Product() { ProductId = 1090, Product_Name = "Shirt", Price = 567, Description = "The Shirt is in red Color" };
            Product product2 = new Product() { ProductId = 2090, Product_Name = "Pant", Price = 300, Description = "The Pant size is 34" };
            Product product3 = new Product() { ProductId = 3090, Product_Name = "Shoes", Price = 100, Description = "The Shoe is made up of leather" };

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
        }
        //Returns a jsonstring of the product if available or returns NULL
        public string find(string req_Product)
        {
            foreach(Product product in products)
            {
                if(product.Product_Name==req_Product) return JsonConvert.SerializeObject(product);
            }
            cust_req_list.Add(req_Product);
            return null;
        }
        //Admin adds the product if the product which is added is in customer required list then event is invoked 
        public void AddProduct(Notification notification)
        {
            Console.WriteLine("Enter the password to add the product");
            string password=Console.ReadLine();
            if (password == "1234")
            {
                Console.WriteLine("Tie product is adding successfully to the product list");
                Product new_Product = new Product() { ProductId = 4090, Product_Name = "Tie", Price = 50, Description = "The Tie is of Blue Color" };
                products.Add(new_Product);
                if (cust_req_list.Contains(new_Product.Product_Name))
                {
                    //invokes the event by calling the Notificaition_Invoke which is in notification object
                    notification.Notification_Invoke();
                }
            }
        }
    }
}
