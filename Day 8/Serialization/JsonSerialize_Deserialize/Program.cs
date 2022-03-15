using System;
namespace Serialization
{
    public static class MainClass
    {
        public static void Main(String[] args)
        {
            Student studentToSerialization = new Student() { Id = 6, Name = "Kanna", Email = "Kanna210@gmail.com", Marks = 89.6 };
            Student deserializedstudent;

            string pathjsonFile = @"C:\Users\vatsitar\Desktop\My Works\Internship Works\Days\Day 8\Serialization\JsonSerialize_Deserialize\Sample.json";
            DataJsonSerializer jsonSerializer = new DataJsonSerializer();
            jsonSerializer.jsonserializer(studentToSerialization, pathjsonFile);

            deserializedstudent = jsonSerializer.jsonDeserialize(typeof(Student), pathjsonFile) as Student;
            Console.WriteLine(deserializedstudent.Id);
            Console.WriteLine(deserializedstudent.Name);
            Console.WriteLine(deserializedstudent.Email);
            Console.WriteLine(deserializedstudent.Marks);

        }
    }
}
