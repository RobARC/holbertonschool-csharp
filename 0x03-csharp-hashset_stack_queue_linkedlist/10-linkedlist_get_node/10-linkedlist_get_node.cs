using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
         int count = 0;
        foreach(var item in myLList)
        {
             //Console.WriteLine(item);
            if (count == n)
            {
                return item;
            }
            count++;
        }
        return 0;
    }
}
