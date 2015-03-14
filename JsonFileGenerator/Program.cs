using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonFileGenerator.Models;
using System.IO;
using JsonFileGenerator.Config;

namespace JsonFileGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputFile = AppConfiguration.Config.OutputPath + "output.json";

            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }

            Product product = new Product
            {
                Name = "Apple",
                Expiry = new DateTime(2008, 12, 28),
                Price = 3.99M,
                Sizes = new[] { "Small", "Medium", "Large" }
            };

            var products = new List<Product>() {product, product};
            
            File.WriteAllText(AppConfiguration.Config.OutputPath + "output.json", JsonConvert.SerializeObject(products, Formatting.Indented));

        }
    }
}
