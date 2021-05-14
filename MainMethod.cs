using System;
using System.Collections.Generic;
using System.Text;


namespace CodilityChallenges
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            /*            AddingItems ai = new AddingItems();
                        Console.WriteLine(ai.solution(new int[] { 4850, 100, 30, 30, 100, 50, 100 })); // 3
                        Console.WriteLine(ai.solution(new int[] { 4650, 150, 150, 150 })); // 2

                        FibonacciSequence fs = new FibonacciSequence();
                        Console.WriteLine(fs.solution(15)); // 2

                        NumOfDiscIntersections nodi = new NumOfDiscIntersections();
                        Console.WriteLine(nodi.Solution(new int[] { 1, 5, 2, 1, 4, 0 })); // 11

                        Nesting n = new Nesting();
                        Console.WriteLine(n.Solution("(()(())())")); // 1
                        Console.WriteLine(n.Solution("())")); // 0 

                        NumOfDiscIntersections nodi = new NumOfDiscIntersections();
                        Console.WriteLine(nodi.Solution(new int[] { 1, 5, 2, 1, 4, 0 })); // 11 
            */
            Brackets b = new Brackets();
            Console.WriteLine(b.Solution ("{[()()]}") );
            Console.WriteLine(b.Solution("([)()]"));

        }
    }
}
