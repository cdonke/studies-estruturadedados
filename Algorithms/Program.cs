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
            if (args.Length > 0 && args[0] == "--all")
                BenchmarkRunner.Run(typeof(Program).Assembly);
            else
                BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
