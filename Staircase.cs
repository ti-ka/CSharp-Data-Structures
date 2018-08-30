using System;
using System.Collections.Generic;

namespace dotnet
{
/*
There's a staircase with N steps, and you can climb 1 or 2 steps at a time.
Given N, write a function that returns the number of unique ways you can 
climb the staircase. The order of the steps matters.

For example, if N is 4, then there are 5 unique ways:
1, 1, 1, 1
2, 1, 1
1, 2, 1
1, 1, 2
2, 2
What if, instead of being able to climb 1 or 2 steps at a time, 
you could climb any number from a set of positive integers X? 
For example, if X = {1, 3, 5}, you could climb 1, 3, or 5 steps at a time. 
Generalize your function to take in X.
*/
    class Staircase
    {
        // to-do: implement momorization
        public void run()
        {
            Console.WriteLine(num_ways(1, new int[] {1, 2}));
            Console.WriteLine(num_ways(2, new int[] {1, 2}));
            Console.WriteLine(num_ways(3, new int[] {1, 2}));
            Console.WriteLine(num_ways(4, new int[] {1, 2}));
        }

        public int num_ways(int n, int[] steps) {

            if (n <= 1)
                return 1;

            var result = 0;
            for(var i = 0; i < steps.Length; i++) {
                result += num_ways(n - steps[i], steps);
            }

            return result;
        }    

    }
}
