using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodilityChallenges
{
    class MaxProfit
    {
        // 23171, 21011, 21123, 21366, 21013, 21367
        // 5, -7, 3, 5, -2, 4, -1
        public int Solution(int[] A)
        {
            // find maximum slice
/*            int max_number = 0;
            int max_slice = 0;

            foreach (var a in A)
            {
                max_number = Math.Max(0, max_number + a);
                max_slice = Math.Max(max_slice, max_number);
            }

            return max_slice;*/

            if (A.Length <= 1)
            {
                return 0;
            }

            int max_profit = 0;
            int max_slice = 0;

            for (int i = 1; i < A.Length; i++)
            {
                max_profit = Math.Max(0, max_profit + A[i] - A[i - 1]);
                max_slice = Math.Max(max_slice, max_profit);
            }

            return max_slice;
        }
    }
}
