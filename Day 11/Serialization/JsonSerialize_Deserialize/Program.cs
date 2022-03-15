using System;
namespace Serialization
{
    public static class MainClass
    {
        public static void Main(String[] args)
        {
            Student employeeToSerialization = new Student() { Id = 6, Name = "Kanna", Email = "Kanna980@gmail.com", Marks = 89.6 };
            Student deserializedstudent;

            string pathjsonFile = @"C:\Users\vatsitar\Desktop\My Works\Internship Works\Azure Pushes\PSI-2022-Jan-DotNet-Batch\Manideep\Assesment 2\Ecommerce App\Sample.json";
            DataJsonSerializer jsonSerializer = new DataJsonSerializer();
            jsonSerializer.jsonserializer(employeeToSerialization, pathjsonFile);

            deserializedstudent = jsonSerializer.jsonDeserialize(typeof(Student), pathjsonFile) as Student;
            Console.WriteLine(deserializedstudent.Id);
            Console.WriteLine(deserializedstudent.Name);
            Console.WriteLine(deserializedstudent.Email);
            Console.WriteLine(deserializedstudent.Marks);

        }
    }
}
