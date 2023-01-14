using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        try
        {
            int first = myLList.First.Value;
            return first;
        }
        catch
        {
            return 0;
        }
    }
}
