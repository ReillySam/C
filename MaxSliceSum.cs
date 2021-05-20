using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChallenges
{
    class MaxSliceSum
    {
        public int Solution(int[] A)
        {
            // 2, 3, -6, 4, 0

            if (A.Length <= 1)
            {
                return A[0];
            }

            // Solution 1
/*            int max_sum = A[0];
            int sum = 0;

            foreach (var item in A)
            {
                sum += item;
                if (sum > max_sum)
                {
                    max_sum = sum;
                }

                if (sum < 0)
                {
                    sum = 0;
                }
            }

            return max_sum;*/


            // Solution 2
            int max_sum = A[0];
            int max_slice = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                max_sum = Math.Max(max_sum + A[i], A[i]);
                max_slice = Math.Max(max_slice, max_sum); 
            }

            return max_slice;
        }
    }
}
