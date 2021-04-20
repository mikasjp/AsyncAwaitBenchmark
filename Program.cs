using BenchmarkDotNet.Running;

namespace AsyncAwaitBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}
