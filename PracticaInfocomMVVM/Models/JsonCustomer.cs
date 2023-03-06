using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInfocomMVVM.Models
{
    internal abstract class JsonCustomer
    {
        public static string JsonFileWay { get; set; }
        public static List<Employeer> Deserialization(string jsonFile)
        {
            var jsonString = File.ReadAllText(jsonFile);
            var deserializedEmployees = JsonConvert.DeserializeObject<List<Employeer>>(jsonString);
            return deserializedEmployees;
        }

        public static void Serialization(List<Employeer> employees, string jsonFile)
        {
            File.WriteAllText(jsonFile, JsonConvert.SerializeObject(employees));
        }

    }
}
