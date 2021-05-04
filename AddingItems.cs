using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChallenges
{
    class AddingItems
    {
        public int solution(int[] A)
        {
            int K = A[0];
            int counter = 0;
            int maxCapacity = 5000;

            int remainderCap = maxCapacity - K;
            Array.Sort(A);

            for (int i = 0; i < A.Length -1; i++)
            {
                remainderCap -= A[i];
                counter++;
                if (A[i] > remainderCap)
                {
                    break;
                }
            }
            return counter;
        }

/*        static void Main(string[] args)
        {
            AddingItems ai = new AddingItems();
            Console.WriteLine(ai.solution(new int[] { 4850, 100, 30, 30, 100, 50, 100 })); // 3
            Console.WriteLine(ai.solution(new int[] { 4650, 150, 150, 150 })); // 2
        }*/
    }
}
