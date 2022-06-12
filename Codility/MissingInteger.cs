using System;
using System.Linq;

namespace MissingInteger
{
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can write to stdout for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");
    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var min = 1;
            for (int i = 1; i <= FindMaxNumber(A) + 1; i++)
            {
                if (!A.Any(c => c == i))
                {
                    min = i;
                    break;
                }
            }
            return min;

        }
        private int FindMaxNumber(int[] arr)
        {
            var max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
    }
}