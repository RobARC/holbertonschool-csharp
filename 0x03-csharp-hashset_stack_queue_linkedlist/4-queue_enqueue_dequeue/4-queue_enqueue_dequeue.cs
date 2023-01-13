using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Queue<string> queueCopy = new Queue<string>(aQueue.ToArray());

        var check = true;
        var aux = "";

        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count > 0)
            Console.WriteLine("First item: {0}", queueCopy.Dequeue());
        else
            Console.WriteLine("Queue is empty");
        
        aQueue.Enqueue(newItem);

        if(aQueue.Contains(search))
            Console.WriteLine($"Queue contains \"{search}\": True");
        else
            Console.WriteLine($"Queue contains \"{search}\": False");

        while (check)
        {
            aux= aQueue.Dequeue();
            if( String.Equals(search, aux))
                check = false;
            
        }

        return aQueue;
    }
}
