using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChallenges
{
    class StoneWall
    {
        public int Solution(int[] H)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            // 8,8,5,7,9,8,7,4,8

            Stack<long> block_stack = new Stack<long>();
            int block_count = 0; 

            // taller blocks will cover smaller ones. Remove all blocks smaller than H[height]. If we encounter a taller block add it

            foreach (long height in H)
            {
                while (block_stack.Count > 0 && block_stack.Peek() > height)
                {
                    block_stack.Pop();
                }


                if (block_stack.Count == 0 || block_stack.Peek() < height)
                {
                    block_stack.Push(height);
                    block_count++;
                }

            }

            return block_count;
        }
    }
}
