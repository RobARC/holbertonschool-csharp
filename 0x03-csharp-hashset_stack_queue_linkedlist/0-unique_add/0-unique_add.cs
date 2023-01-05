using System;
using System.Collections.Generic;

class List 
{
    public static int Sum(List<int> myList)
    {
        int mySum = 0;
       IEnumerable<int> sum = myList.Distinct();

       foreach (int num in sum){
        mySum += num;
       }

        return mySum;
    }
}
