using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> myList = new List<int>();
        List<int> newList = new List<int>();

        //Put together the two lists
        foreach(var i in list1)
            myList.Add(i);
        foreach(var j in list2)
            myList.Add(j);
        
        //Sort by bubble sort method
        int temp = 0;
        for(int x = 0; x < myList.Count; x++)
        {
            for(int z = 0; z < myList.Count -1; z++ )
            {
                if(myList[z] > myList[z +1])
                {
                    temp= myList[z + 1];
                    myList[z + 1] = myList[z];
                    myList[z] = temp;
                }
            }          
        }
        //Remove the repeaters numbers
        for(int w = 0; w < myList.Count - 1; w++)
        {
            if(myList[w] == myList[w +1])
            {
                myList.Remove(myList[w]);
                myList.Remove(myList[w]);

            }
        }
        return myList;
    }
}
