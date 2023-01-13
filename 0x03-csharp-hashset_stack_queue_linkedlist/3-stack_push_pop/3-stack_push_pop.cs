using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        string aux = "";
        bool check = true;
       
        Console.WriteLine("\nNumber of items: {0}", aStack.Count);

        if (aStack.Count > 0)
            Console.WriteLine("\nTop item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");

        if(aStack.Contains(search))
            Console.WriteLine($"\nStack contains \"{search}\": True");
        else
            Console.WriteLine($"\nStack contains \"{search}\": False");

        while (check)
    
        {
            aux = aStack.Peek();
            if(String.Equals(search, aux))
                check = false;
            aStack.Pop();
        }

        aStack.Push(newItem);

        return aStack;

    }
}