using System;
using System.Collections.Generic;
using System.Text;


namespace CodilityChallenges
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            /*  AddingItems ai = new AddingItems();
            Console.WriteLine(ai.solution(new int[] { 4850, 100, 30, 30, 100, 50, 100 })); // 3
            Console.WriteLine(ai.solution(new int[] { 4650, 150, 150, 150 })); // 2

            FibonacciSequence fs = new FibonacciSequence();
            Console.WriteLine(fs.solution(15)); // 2

            NumOfDiscIntersections nodi = new NumOfDiscIntersections();
            Console.WriteLine(nodi.Solution(new int[] { 1, 5, 2, 1, 4, 0 })); // 11

            Nesting n = new Nesting();
            Console.WriteLine(n.Solution("(()(())())")); // 1
            Console.WriteLine(n.Solution("())")); // 0 

            Brackets b = new Brackets();
            Console.WriteLine(b.Solution("{[()()]}"));
            Console.WriteLine(b.Solution("([)()]"));

            StoneWall sw = new StoneWall();
            Console.WriteLine(sw.Solution(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }));


            EquiLeader el = new EquiLeader();
            Console.WriteLine(el.Solution(new int[] { 4, 3, 4, 4, 4, 2 })); // 2


            MaxProfit mp = new MaxProfit();
            Console.WriteLine(mp.Solution(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 })); // 356
            Console.WriteLine(mp.Solution(new int[] { 5, -7, 3, 5, -2, 4, -1 })); // 3, 5, -2, 4

            MaxSliceSum mss = new MaxSliceSum();
            Console.WriteLine(mss.Solution(new int[] { 2, 3, -6, 4, 0 })); // 5
            
            MaxDoubleSliceSum mdss = new MaxDoubleSliceSum();
            Console.WriteLine(mdss.Solution(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 })); // 5

            */

            MinPerimeterRectangle mpr = new MinPerimeterRectangle();
            Console.WriteLine(mpr.Solution( 30 )); // 22
            Console.WriteLine(mpr.Solution(36)); // 24

        }
    }
}
