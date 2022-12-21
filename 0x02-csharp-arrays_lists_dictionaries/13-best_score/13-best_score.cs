using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            string key = null;
            int myValue = 0;

            if (myList == null || myList.Count == 0){
                return "None";
            }

            foreach (KeyValuePair<string, int> kvp in myList)
            {
                if(kvp.Value >= myValue)
                {
                    key = kvp.Key;
                    myValue = kvp.Value;
                }
            }

            return key;
        }
    }

