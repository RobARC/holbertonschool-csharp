using System;

class Line
{
    public static void PrintLine(int length)
    {
        string character = "_";

        if(length == 0)
        {
            Console.WriteLine("$");
        }
        else 
        {
           for (int i = 0; i< length; i++)
           {
            Console.Write(character);
           }
           Console.WriteLine("$");
        }
    }
}