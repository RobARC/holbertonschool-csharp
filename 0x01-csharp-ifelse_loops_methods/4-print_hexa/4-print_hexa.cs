using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 99; i++)
            Console.Write($"{i:d} = 0x{i:x}\n");
        }
    }
}
