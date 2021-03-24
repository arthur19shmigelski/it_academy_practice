using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class UniqueItem
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public UniqueItem()
        {
            id++;
        }
        public static void DisplayId(UniqueItem item)
        {
            Console.WriteLine($"Create {item.Id} - instance.");
        }
    }
}
