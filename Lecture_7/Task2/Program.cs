using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 32;
            object boxingFirstValue = firstValue;

            char secondValue = 'A';
            object boxingSecond = secondValue;

            string thirdValue = "Hello";
            object boxingThird = thirdValue;

            object[] objectArray = new object[3] { boxingFirstValue, boxingSecond, boxingThird };

            for (int i = 0; i < objectArray.Length; i++)
            {
                Console.WriteLine(objectArray[i]);
            }
            objectArray[0] = Convert.ToInt32(objectArray[0]) + 10;
            objectArray[2] = Convert.ToString(objectArray[2]) + ", guys";
            for (int i = 0; i < objectArray.Length; i++)
            {
                Console.WriteLine(objectArray[i]);
            }
        }
    }
}
