using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Text.Json.JsonSerializer;
using System.Linq;


namespace CodilityChallenges
{
    class Nesting
    {
        // (()(())())
        // ())
        public int Solution(string S)
        {
            if (S.Length % 2 != 0)
            {
                return 0;
            }

            Stack<char> my_stack = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    my_stack.Push(S[i]);
                }

                else if (S[i] == ')')
                {
                    
                    if (my_stack.Count == 0 || my_stack.Peek() != '(')
                    {
                        return 0;
                    }

                    my_stack.Pop();

                }

            }

            if (my_stack.Count == 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
