using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace SerializeAndDeserialize
{
    public class MainClass
    {
        private const string V = "Sample.txt";

        public static void Main(String[] args)
        {
            OtherClass obj=new OtherClass();
            obj.id = 1;
            obj.name = "Kanna";
            SerailizeText(obj);
            DeserializeText();

        }
        public static void SerailizeText(OtherClass obj)
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("C:\\Sample.txt", FileMode.OpenOrCreate);
            formatter.Serialize(stream, obj);
            stream.Close();
        }
        public static void DeserializeText()
        {
            FileStream stream = new FileStream("C:\\Sample.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            OtherClass s = (OtherClass)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.id);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
        }
    }
    [Serializable]
    public class OtherClass
    {
       public int id;
       public string name;
    }
}