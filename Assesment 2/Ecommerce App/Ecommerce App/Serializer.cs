using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
namespace Ecommerce_App
{
    internal class DataJsonSerializer
    {
        public void jsonserializer(object dataobject, string filepath)
        {
            //Serialize the product
            JsonSerializer serializer = new JsonSerializer();
            if (File.Exists(filepath))
                File.Delete(filepath);
            TextWriter writer = new StreamWriter(filepath);
            JsonTextWriter jsonTextWriter = new JsonTextWriter(writer);
            serializer.Serialize(jsonTextWriter, dataobject);
            jsonTextWriter.Close();
            writer.Close();
        }

        public object jsonDeserialize(Type dataType, string filepath)
        {
            //Deserialize the product
            JObject obj = null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filepath))
            {

                TextReader reader = new StreamReader(filepath);
                JsonTextReader jsonTextReader = new JsonTextReader(reader);
                obj = jsonSerializer.Deserialize(jsonTextReader) as JObject;
                jsonTextReader.Close();
                reader.Close();
            }
            return obj.ToObject(dataType);

        }
    }
}