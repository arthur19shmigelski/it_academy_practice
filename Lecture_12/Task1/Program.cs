using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem uniq1 = new UniqueItem(1);
            UniqueItem uniq2 = new UniqueItem(5);
            UniqueItem uniq3 = new UniqueItem(10);
            UniqueItem uniq4 = new UniqueItem(15);
            UniqueItem.DisplayId();
        }
    }
    class UniqueItem
    {
        private static int Id = 0;
        public UniqueItem(int id)
        {
            Id = id;
            Id++;
        }
        public static void DisplayId()
        {
            Console.WriteLine($"Create {Id} - instance.");
        }
    }
}
