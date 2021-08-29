using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort MS = new MergeSort();
            List<int> L = new List<int>() { 1, 3, 2, 9, 4, 7 };
            int[] Arr =  new int[] { 1, 3, 2, 9, 4, 7 };
            int len = Arr.Length - 1;
            QuickSort QS = new QuickSort();
             QS.Sort(Arr, 0, len);
            Console.WriteLine(string.Join(",", Arr));
 

            Console.WriteLine(string.Join(",", MS.sort(L)));
        }
    }
}
