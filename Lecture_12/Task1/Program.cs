using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem uniq1 = new UniqueItem();
            UniqueItem uniq2 = new UniqueItem();
            UniqueItem uniq3 = new UniqueItem();
            UniqueItem uniq4 = new UniqueItem();
            UniqueItem.DisplayId();
        }
    }
    class UniqueItem
    {
        private static int Id = 0;
        public UniqueItem()
        {
            Id++;
        }
        public static void DisplayId()
        {
            Console.WriteLine($"Create {Id} - instance.");
        }
    }
}
