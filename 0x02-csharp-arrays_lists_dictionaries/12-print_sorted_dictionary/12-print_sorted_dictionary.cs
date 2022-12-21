using System;
using System.Collections.Generic;
    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            List<string> myList = new List<string>();
            Dictionary<string, string> myNewDict = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> pair in myDict)
            {
                myList.Add(pair.Key);
            }
            myList.Sort();
            foreach (var key in myList)
            {
                myNewDict[key] = myDict[key];
            }

            foreach(KeyValuePair<string, string> pair in myNewDict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }

