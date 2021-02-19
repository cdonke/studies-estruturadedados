using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.BinaryGap
{
    public static class BinaryConverter
    {
        public static Stack<int> Convert(int N)
        {
            var stack = new Stack<int>();
            while (N != 0)
            {
                stack.Push(N % 2);
                N /= 2;
            }

            return stack;
        }
    }
}
