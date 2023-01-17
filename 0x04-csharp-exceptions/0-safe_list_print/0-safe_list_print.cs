using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int counter = n;
        try
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
            }
            return counter;
        }
        catch (ArgumentOutOfRangeException)
        {
            return myList.Count;

        }
       
    }
}
