using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_App
{
    internal class Factory
    {
        List<Product> products = new List<Product>();
        public Product find(string req_ProductName)
        {
            //Find the product and return the product
            foreach (Product p in products)
            {
                if (p.Product_Name == req_ProductName) return p;

            }
            return null;

        }
        public Factory()
        {
            //Factory constructor initial products in product list
            Product product1 = new Product() { ProductId = 1090, Product_Name = "Shirts", Price = 567, Description = "The Shirt is in red Color" };
            Product product2 = new Product() { ProductId = 2090, Product_Name = "Pants", Price = 300, Description = "The Pant size is 34" };
            Product product3 = new Product() { ProductId = 3090, Product_Name = "Shoes", Price = 100, Description = "The Shoe is made up of leather" };

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

        }
        public void Create_Product()
        {
            //If the user is admin he can add a product to the product list
            Product newproduct = new Product();
            Console.WriteLine("Enter the product id");
            newproduct.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the product Name");
            newproduct.Product_Name = Console.ReadLine();
            Console.WriteLine("Enter the Price of the product");
            newproduct.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Description of the product");
            newproduct.Description = Console.ReadLine();

        }

    }
}
