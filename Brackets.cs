using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityChallenges
{
    class Brackets
    {
        // {[()()]}
        // ([)()]
        public int Solution(string S)
        {
            if (S.Length == 0)
            {
                return 1;
            }

            Stack<char> my_stack = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '{' || S[i] == '[' || S[i] == '(')
                {
                    my_stack.Push(S[i]);
                }

                else
                {
                    if (my_stack.Count == 0 
                        || S[i] == '}' && my_stack.Peek() != '{'
                        || S[i] == ']' && my_stack.Peek() != '['
                        || S[i] == ')' && my_stack.Peek() != '(')
                    {
                        return 0;
                    }

                    my_stack.Pop();
                }

            }

            if (my_stack.Count != 0)
            {
                return 0;
            }

            return 1;
        }
    }
}
