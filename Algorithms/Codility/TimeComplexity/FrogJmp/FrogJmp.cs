using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.TimeComplexity.FrogJmp
{
    public class FrogJmp
    {
        public int FirstTry(int X, int Y, int D)
        {
            return (int)Math.Ceiling((Y - X) / (double)D);
        }
    }
}
