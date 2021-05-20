using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChallenges
{
    class MaxDoubleSliceSum
    {
        // The sum of double slice (X, Y, Z) is the total of A[X + 1] + A[X + 2] + ... + A[Y − 1] + A[Y + 1] + A[Y + 2] + ... + A[Z − 1].
        // 3, 2, 6, -1, 4, 5, -1, 2
        public int Solution(int[] A)
        {
            // split the array into start A[X + 1]... A[Y -1] && A[Y + 1]...A[Z - 1]
            int[] starting_here = new int [A.Length];
            int[] ending_here = new int [A.Length];

            int max_double_slice = 0;

            if (A.Length <= 3)
            {
                return 0;
            }

            for (int i = 1; i < A.Length - 2; i++)
            {
                ending_here[i] = Math.Max(0, ending_here[i - 1] + A[i]);
            }

            for (int i = A.Length - 2; i > 0; i--)
            {
                starting_here[i] = Math.Max(0, starting_here[i + 1] + A[i]);
            }

            // Double slice sum should be the maximum sum of ending_here_sum[i-1]+starting_here_sum[i+1]
            max_double_slice = ending_here[0] + starting_here[2];
            for (int i = 1; i < A.Length - 1; i++)
            {
                max_double_slice = Math.Max(max_double_slice, ending_here[i - 1] + starting_here[i + 1]);
            }

            return max_double_slice;
        }
    }
}
