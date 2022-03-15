using System;
namespace Factory_Pattern
{
    public class Employee
    {
       static void Main(String[] args)
        {
            Console.WriteLine("Enter what type of laptop u want");
            string laptop=Console.ReadLine();
            Company company=new Company();
            IProducts laptop_product = company.getProduct(laptop);
            laptop_product.Product();
        }
    }
}