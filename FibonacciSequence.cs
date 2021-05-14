using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChallenges
{
    class FibonacciSequence
    {

        public int solution(int X)
        {
            var fibonnaciNumbers = fibonnaciNumbersArray();

            // check if X is a fib number
            if (fibonnaciNumbers.Contains(X))
                return 0;

            else
            {
                for (int i = 0; i < fibonnaciNumbers.Count - 2; i++)
                {
                    var current = fibonnaciNumbers[i];
                    var next = fibonnaciNumbers[i + 1];

                    // X is between two Fib numbers
                    if (current < X && X < next)
                    {
                        // Get the difference it is from each
                        var distanceFromCurr = X - current;
                        var distanceFromNext = next - X;

                        // return the minimum of the two 
                        return Math.Min(distanceFromCurr, distanceFromNext);
                    }
                }
            }
            return 0;
        }
         

        private List<int> fibonnaciNumbersArray()
        {
            // create a map for fib numbers. 
            var fibNums = new List<int>();

            fibNums.Add(0);
            fibNums.Add(1);

            int next = 1;
            int i = 2;

            while (next < 1000000)
            {
                next = fibNums[i - 2] + fibNums[i - 1];
                fibNums.Add(next);
                i++;
            }

            return fibNums;
        }

    }
}
