using System;
using System.Collections.Generic;

class List 
{
    public static int Sum(List<int> myList)
    {
        int mySum = 0;
       HashSet<int> sum = new HashSet<int>(myList);

       foreach (int num in sum){
        mySum += num;
       }

        return mySum;
    }
}
