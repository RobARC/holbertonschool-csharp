using System;
using System.Collections.Generic;

namespace _0_unique_add
{
    class List
    {
        public static int Sum(List<int> myList)
        {
            int sum = 0;
            HasSet<int> set = new HasSet<int>(myList);
            foreach (int num in set)
                sum += num;

            return sum;
        }
    }
}
