using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;

        if (myLList.First.Value >= n)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }

        foreach(var item in myLList)
        {
            if(item < n )
            {
                current = current.Next;
                if(current.Next == null)
                {
                    myLList.AddLast(n);
                    return myLList.Last;
                }
            }
        }
        myLList.AddBefore(current, n);
        return current.Previous;
    }
}
