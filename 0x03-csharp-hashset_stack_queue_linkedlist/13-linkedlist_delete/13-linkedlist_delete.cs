using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        
        LinkedListNode<int> current = myLList.First;
        if(index == 0)
        {
            myLList.RemoveFirst();
            return;
        }
        if (index == myLList.Count -1)
        {
            myLList.RemoveLast();
            return;
        }

        for (int i = 0; i < myLList.Count; i++)
        {
            if(i == index)
            {
                myLList.Remove(current);
                break;
            }
            current = current.Next;
        }
        
        return;
    }
}
