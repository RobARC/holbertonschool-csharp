using System;

namespace _100_hello_error
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "and that piece of art is useful - Dora Korpar, 2015-10-19";
            Console.Error.WriteLine(str);
            Environment.Exit(1);
        }
    }
}
