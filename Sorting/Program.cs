using System;
using System.Collections.Generic;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSort MS = new MergeSort();
            List<int> L = new List<int>() { 1, 3, 2, 9, 4, 7 };
            

            Console.WriteLine(string.Join(",", MS.sort(L)));
        }
    }
}
