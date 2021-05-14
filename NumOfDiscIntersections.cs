using System;
using System.Collections.Generic;
using static System.Text.Json.JsonSerializer;
using System.Text;
using System.Linq;

namespace CodilityChallenges
{
    class NumOfDiscIntersections
    {
        // A = 1, 5, 2, 1, 4, 0 
        public int Solution(int[] A)
        {

            // create an array of start and end point pairs, centre point +/- r
            int[] start_p = new int[A.Length];
            int[] end_p = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                start_p[i] = i - A[i];

                // handle max value overflow. Max end point has to be integer max value
                if (int.MaxValue - A[i] < i)
                {
                    end_p[i] = int.MaxValue;
                }

                else
                {
                    end_p[i] = i + A[i];
                }
            }

            // Sort the array 
            Array.Sort(start_p);
            Array.Sort(end_p);

            // count open (++) and closed discs (--) , from start and end points linearly for the length of A, discs greater will not intersect
            int result = 0;
            int open = 0;

            int start_p_idx = 0;
            int end_p_idx = 0;

            while (start_p_idx < A.Length)
            {
                if (start_p[start_p_idx] <= end_p[end_p_idx])
                {
                    result = result + open;

                    if (result > 10000000)
                    {
                        return -1;
                    }

                    open++;
                    start_p_idx++;
                }

                else
                {
                    open--;
                    end_p_idx++;
                }

            }

            return result;
        }
    }
}
