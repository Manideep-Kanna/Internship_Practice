using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_App
{
    internal class serailize_Product
    {
        public void Serialize_Product(Product req_product)
        {
            //Serializing the product 
            Product deserializedproduct;
            string pathjsonFile = @"C:\Users\vatsitar\Desktop\My Works\Internship Works\Azure Pushes\PSI-2022-Jan-DotNet-Batch\Manideep\Assesment 2\Ecommerce App\Ecommerce App\Sample.json";
            DataJsonSerializer jsonSerializer = new DataJsonSerializer();
            jsonSerializer.jsonserializer(req_product, pathjsonFile);

            deserializedproduct = jsonSerializer.jsonDeserialize(typeof(Product), pathjsonFile) as Product;
            Console.WriteLine($"The product id is {deserializedproduct.ProductId}");
            Console.WriteLine($"The name of the product is {deserializedproduct.Product_Name}");
            Console.WriteLine($"The price of the product is {deserializedproduct.Price}");
            Console.WriteLine(deserializedproduct.Description);
        }
    }
}
