using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int Counter = 0;
        foreach(KeyValuePair<string, string> pair in myDict)
        {
            Counter += 1;
        }
        return Counter;
    }
}