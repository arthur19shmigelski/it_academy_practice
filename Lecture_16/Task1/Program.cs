using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Option 1 (string value) - передал string в метод
            MyClass my = new MyClass();
            my.DeleteCharAfterFive("Input youre name: ");
            #endregion

            #region Option 2 (StringBuilder) -  передал StringBuilder в метод
            StringBuilder sb1 = new StringBuilder();
            sb1.DeleteCharAfterFive("Input youre name: ");
            #endregion

        }
    }
    internal class MyClass
    {
        internal string _name;
    }
    static class ExtensionClass
    {
        public static void DeleteCharAfterFive(this MyClass instance, string text)
        {
            Console.Write(text);
            instance._name = Console.ReadLine();
            const int firstFiveLetters = 5;
            instance._name = instance._name.Remove(firstFiveLetters, instance._name.Length - firstFiveLetters) + "...";
            Console.WriteLine("Total value - " + instance._name);
        }
    }
    public static class StringBuilderExtensions
    {
        public static void DeleteCharAfterFive(this StringBuilder sb, string text)
        {
            Console.Write(text);
            const int firstFiveLetters = 5;
            sb = new StringBuilder(Console.ReadLine());
            sb.Remove(firstFiveLetters, sb.Length - firstFiveLetters);
            sb.Insert(firstFiveLetters, "...");
            Console.WriteLine("Total value - " + sb);
        }
    }
}