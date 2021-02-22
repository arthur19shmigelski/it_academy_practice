using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            short userValue = 125;
            Object boxing = userValue;
            Int16 unboxing = (SByte)boxing;
            Console.WriteLine("Value = " + unboxing + ". Type = " + unboxing.GetType());
        }
    }
}
