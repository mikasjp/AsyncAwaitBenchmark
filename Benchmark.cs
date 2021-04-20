using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace AsyncAwaitBenchmark
{
    public class Benchmark
    {
        private TestClass testObject = new TestClass();

        [Benchmark]
        public async Task NoRedundantOperators()
        {
            await testObject.MethodA();
        }

        [Benchmark(Baseline = true)]
        public async Task RedundantOperators()
        {
            await testObject.MethodB();
        }
    }
}