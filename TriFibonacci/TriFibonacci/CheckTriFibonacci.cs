using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFibonacci
{
    class CheckTriFibonacci
    {
        public int Complete(int[] A)
        {
            int NumberInsteadOfMinusOne;
            int indexOfMinusOne = Array.IndexOf(A, -1);
            if (indexOfMinusOne == 0)
            {
                int i = 1;
                int sum = A[i + 2] - A[i + 1] - A[i];
                A[0] = sum;
            }
            if (indexOfMinusOne == A.Length - 1)
            {
                A[indexOfMinusOne] = A[indexOfMinusOne - 1] + A[indexOfMinusOne - 2] + A[indexOfMinusOne - 3];
            }
            if ((indexOfMinusOne >= 2))
            {
                if (indexOfMinusOne <= A.Length - 2)
                {
                    A[indexOfMinusOne] = A[indexOfMinusOne + 1] - (A[indexOfMinusOne - 1] + A[indexOfMinusOne - 2]);
                }
            }
            if (indexOfMinusOne == 1)
            {
                A[indexOfMinusOne] = A[indexOfMinusOne + 2] - A[indexOfMinusOne + 1] - A[indexOfMinusOne - 1];
            }
            NumberInsteadOfMinusOne = Checkseries(A, indexOfMinusOne);
            return NumberInsteadOfMinusOne;
        }
        private int Checkseries(int[] A, int indexOfMinusOne)
        {
            int k = 0;
            int flag = 1;
            while (k <= A.Length - 4)
            {
                int sum = 0;
                for (int j = k; j < k + 3; j++)
                {
                    sum = sum + A[j];
                }
                if (sum != A[k + 3])
                {
                    flag = 0;
                }
                k++;
            }
            if (flag == 1)
            {
                return A[indexOfMinusOne];
            }
            else
                return 0;
        }
    }
}
