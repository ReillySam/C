using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChallenges
{
    class EquiLeader
    {
        // 4, 3, 4, 4, 4, 2
        public int Solution(int[] A)
        {
            Stack<int> my_stack = new Stack<int>();
            int size = my_stack.Count;

            for (int i = 0; i < A.Length; i++)
            {
                if (size == 0)
                {
                    my_stack.Push(A[i]);
                    size++;
                }

                else
                {
                    if (my_stack.Peek() != A[i])
                    {
                        my_stack.Pop();
                        size--;
                    }

                    else
                    {
                        my_stack.Push(A[i]);
                        size++;
                    }
                }

            }

            if (size == 0)
            {
                return 0;
            }

            int leader = my_stack.Peek();
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leader)
                {
                    count++;
                }
            }

            if (count <= A.Length / 2)
            {
                return 0;
            }


            int equi_leader = 0;
            int equi_l_count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leader)
                {
                    equi_l_count++;
                }

                // checking sequences have the same value
                //   A[0], A[1], ..., A[S] and A[S + 1], A[S + 2], ..., A[N − 1]
                if (equi_l_count > (i+1) / 2 && count - equi_l_count > (A.Length - i - 1) / 2)
                {
                    equi_leader++;
                }
            }
            return equi_leader;
        }
    }
}
