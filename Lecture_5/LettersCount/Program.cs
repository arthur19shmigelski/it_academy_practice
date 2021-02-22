using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            string userInp = Console.ReadLine();
            int totalValue = 0;
            for (int i = 0; i < userInp.Length; i++)
            {
                if (userInp[i] == 'a')
                {
                    totalValue = totalValue + 1;
                }
            }
            Console.WriteLine("A in string = " + totalValue);
        }
    }
}
