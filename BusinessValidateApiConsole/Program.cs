using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace BusinessValidateApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new BusinessValidator();
            var result = validator.StatusAsync("220-81-65848").GetAwaiter().GetResult();
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}