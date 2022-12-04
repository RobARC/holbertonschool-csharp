using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        string character = "\\"; 

         if(length == 0)
        {
            Console.WriteLine("$");
        }
         else 
        {
           for (int i = length; i > 0; i--)
           {
            Console.WriteLine(new String(' ', length -i)+ character + "$");
            
           }
           Console.WriteLine("$");
        }

    }
}