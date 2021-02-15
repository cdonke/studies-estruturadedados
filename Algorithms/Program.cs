using BenchmarkDotNet.Running;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Algorithms
{
    class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
