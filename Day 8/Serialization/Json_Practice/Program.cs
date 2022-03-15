using System;
using Newtonsoft.Json;
namespace JsonSerialize_Deserialize
{
    public class JsonSerialize
    {
        public static void Main(String[] args)
        {
            Employee emp = new Employee()
            {
                Name = "Kanna",
                Phone = " 984898489"
            };
            //Creating jsonstring
            string jsonstring = JsonSerializer(emp);
            JsonDeserializer(jsonstring);
        }
        public static string JsonSerializer(Employee emp)
        {
            string jsonString = JsonConvert.SerializeObject(emp);
            return jsonString;
        }
        public static void JsonDeserializer(string s)
        {
            Employee empObj = JsonConvert.DeserializeObject<Employee>(s);
            Console.WriteLine(empObj.Name);
            Console.WriteLine(empObj.Phone);

        }

    }
    public class Employee
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
