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

            var sample = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, Method>>>(inJson);

            var outSample = new Dictionary<string, Dictionary<string, Method>>()
            {
                {  
                    "api/people", new Dictionary<string, Method>()
                    {
                        { "get", new Method() { Authenticated = true } },
                        { "post", new Method() { Authenticated = false } }
                    }
                },
                { 
                    "api/book/{id}", new Dictionary<string, Method>()
                    {
                        { "get", new Method() { Authenticated = true } },
                        { "put", new Method() { Authenticated = true } }
                    }
                }
            };

            string outJson = JsonConvert.SerializeObject(outSample);
        }
    }
}
