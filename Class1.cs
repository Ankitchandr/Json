using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using System.Collections;

namespace ConsoleAppjson
{
    public class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }

        public new void ToString()
        {
            Console.WriteLine("name:{0},age:{1},email:{3}" , name,age,email);
        }

    }

    class Class1
    {

        static void Main(string[] args)
        {
            Class1 a = new Class1();
            a.Jsonserialization();
            a.JsonDeserialization();

            Console.Read();
        }

        public void Jsonserialization()
        {
            Employee obj = new Employee
            {
                name = "Ruhi Chandra",
                age = 89,
                email = "ankit@gmail.com"
            };

            var result = JsonConvert.SerializeObject(obj);
            File.WriteAllText("F:\\Json3.json", result);
            Console.WriteLine("serialzation is done");
        }

        public void JsonDeserialization()
        {
            string str = null;
            str = File.ReadAllText("F:\\Json3.json");
            var dic = JsonConvert.DeserializeObject<IDictionary>(str);

            Console.WriteLine("Employee Details");
            foreach (DictionaryEntry entry in dic) 
            {
                Console.WriteLine(entry.Key+":"+ entry.Value);

            }

        }


        
    }
}
