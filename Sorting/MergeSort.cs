using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MergeSort
    {
        public List<int> sort(List<int> A)
        {
            int ALen = A.Count;
            if (ALen <= 1)
                return A;

            int m = ALen / 2;
            List<int> L = new List<int>();
            List<int> R = new List<int>();
            for (int i = 0; i < m; i++)
            {
                L.Add( A[i]);
            }

            for (int i = m; i < ALen; i++)
            {
                R.Add( A[i]);
            }

            L = sort(L);
            R = sort(R);

            return Merge(L, R);
        }

        public List<int> Merge(List<int> L,List<int> R)
        {
            List<int> M = new List<int>();

            while (L.Count != 0 || R.Count != 0)
            {
                if(L.Count != 0 && R.Count != 0)
                {
                    if (L.First() > R.First())
                    {
                        M.Add(L.First());
                        L.RemoveAt(0);
                    }
                    else 
                    {
                        M.Add(R.First());
                        R.RemoveAt(0);
                    }
                }
                else if (L.Count != 0)
                {
                    M.Add(L.First());
                    L.RemoveAt(0);
                }
                else if(R.Count != 0)
                {
                    M.Add(R.First());
                    R.RemoveAt(0);
                }
            }
            return M;
        }
    }
}
