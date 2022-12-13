using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int Counter = 0;
        foreach(var pair in myDict)
        {
            Counter++;
        }
        return Counter;
    }
}