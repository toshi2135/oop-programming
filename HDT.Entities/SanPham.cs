using System;
namespace HDT.Entities
{
    public class Product : ProductType
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
        public string Company { get; set; }
        public int Year { get; set; }

        // Methods
        public Product()
        {
        }
    }
}
