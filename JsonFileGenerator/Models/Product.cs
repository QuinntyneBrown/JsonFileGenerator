using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFileGenerator.Models
{
    public class Product
    {
        public String[] Sizes { get; set; }
        public decimal Price { get; set; }
        public DateTime Expiry { get; set; }
        public string Name { get; set; }
    }
}
