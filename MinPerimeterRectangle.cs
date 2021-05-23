using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChallenges
{
    class MinPerimeterRectangle
    {
        public int Solution(int N)
        {
            // get divisors of N
            // min perimeter of divisors, min must be the closest element(s) / closest square of N
            // int min_perimeter = Int32.MaxValue;

            int a;

            for (a = (int)Math.Sqrt(N); a > 0; a--)
            {
                if (N % a == 0)
                {
                    break;
                }   
            }

            return 2 * (a + N / a);
        }

    }
}
