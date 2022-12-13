using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> myNewDict = new Dictionary<string, int>(myDict);
        foreach(var item in myDict)
        {
            myNewDict[item.Key] = item.Value * 2;
        }
        return myNewDict;

    }
}
