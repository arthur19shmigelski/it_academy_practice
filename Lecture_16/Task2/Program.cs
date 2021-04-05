using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

        }
    }
    class Product
    {
        public const string ProductType = "Phone";
        private Guid _id;
        public Guid Id { get { return _id; } }

        public string Name { get; set; }

        public Product()
        {
            _id = Guid.NewGuid();
        }
    }
}
