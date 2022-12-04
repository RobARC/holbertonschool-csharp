using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int digit = number % 10;
        if (digit < -1)
        {
            Console.Write(digit * -1);
            return (digit * -1);
        }
        Console.Write(digit);
        return digit;

    }
}