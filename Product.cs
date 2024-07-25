using System;

namespace Webapp_July.Models
{
    public class Product
    {
        public string Name { get; set; }

        // Constructor to initialize the property
        public Product(string name)
        {
            Name = name;
        }
    }
}
