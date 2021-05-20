using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Algorithms.Codility.Exams.NumberOfVisibleNodes
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class NumberOfVisibleNodes
    {
        public class Tree
        {
            public int x;
            public Tree left;
            public Tree right;
        }

        [ExcludeFromCodeCoverage]
        public static IEnumerable<object[]> Data()
        {
            yield return new object[] {
                new Tree {
                    x = 5,
                    left = new Tree
                    {
                        x=3,
                        left = new Tree
                        {
                            x = 20
                        },
                        right = new Tree
                        {
                            x = 21
                        }
                    },
                    right = new Tree
                    {
                        x = 10,
                        left = new Tree
                        {
                            x = 1
                        }
                    }
                }
                , 4
            };

            yield return new object[] {
                new Tree {
                    x = 8,
                    left = new Tree
                    {
                        x=2,
                        left = new Tree
                        {
                            x = 8
                        },
                        right = new Tree
                        {
                            x =7
                        }
                    },
                    right = new Tree
                    {
                        x = 6                        
                    }
                },
                2
            };
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public int FirstTry(Tree T, int expected)
        {
            return countVisible(T, int.MinValue);
        }
        int countVisible(Tree T, int maxValue)
        {
            if (T == null)
            {
                return 0;
            }

            int num = 0;
            if (T.x >= maxValue)
            {
                num = 1;
                maxValue = T.x;
            }

            return num + countVisible(T.left, maxValue) + countVisible(T.right, maxValue);
        }
    }
}
