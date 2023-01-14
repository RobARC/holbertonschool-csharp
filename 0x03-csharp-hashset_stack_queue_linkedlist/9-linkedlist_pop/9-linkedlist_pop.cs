using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int first = myLList.First.Value;
        
        if (myLList.Count < 0 || myLList == null)
            return 0;

        return first;
    }
}
