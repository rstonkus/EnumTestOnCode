using System;
using System.Linq;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace EnumBenchmarkApplication
{
public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<EnumToStringBenchmark>(
                ManualConfig
                    .Create(DefaultConfig.Instance)
                    .With(new Job { LaunchCount = 1, WarmupCount = 2, TargetCount = 10, Runtime = Runtime.Clr })
                    .With(new MemoryDiagnoser())
                    );
        }
    }
}
