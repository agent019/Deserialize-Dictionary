using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Deserialize_Dictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inJson;
            using (StreamReader file = File.OpenText("c:\\dev\\Deserialize-Dictionary\\Deserialize-Dictionary\\sample.json"))
            {
                inJson = file.ReadToEnd();
            }

            var sample = JsonConvert.DeserializeObject<SampleJson>(inJson);
        }
    }
}
