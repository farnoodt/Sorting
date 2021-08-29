using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class QuickSort
    {
        public void Sort(int[] Arr, int Low, int High)
        {
            if (Low < High)
            {
                int pi = Partition(Arr, Low, High);

                Sort(Arr, Low, pi - 1);
                Sort(Arr, pi + 1, High);
            }
            
        }

        private void Swap(int[] Arr, int A, int B)
        {
            int temp = Arr[A];
            Arr[A] = Arr[B];
            Arr[B] = temp;
        }

        private int Partition(int[] Arr, int low, int high)
        {
            int Pivot = Arr[high];
            int i = low - 1;
            for (int j = low; j <= high-1; j++)
            {
                if(Arr[j] < Pivot)
                {
                    i++;
                    Swap(Arr, i, j);
                }
            }
            Swap(Arr, i + 1, high);
            return i + 1;
        }
    }
}
