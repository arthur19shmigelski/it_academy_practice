using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[13];
            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(1, 100);
                Console.WriteLine(" "+randomArray[i]);
            }
            Array.Sort(randomArray);
            Console.WriteLine("Max value in array = " + randomArray[^1]);
        }
    }
}
