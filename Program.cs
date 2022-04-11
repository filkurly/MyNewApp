using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
    class Utility
    {
        public static string Reverse(string message);
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(lettes);
            return new string(letters);
        }
    }
}

namespace MyNewApp.Business
{
    // Classes here
}

namespace MyNewApp.Data
{
    // Classes here
}
