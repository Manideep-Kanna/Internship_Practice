using System.ComponentModel.DataAnnotations;

namespace E_commerce_App
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Product_Name { get; set; } = string.Empty;
        public string Product_Description { get; set; } = string.Empty;
        public string Product_Category { get; set;} = string.Empty;
        public int Product_Price { get; set; }

    }
}
