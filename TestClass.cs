using System.Threading.Tasks;

namespace AsyncAwaitBenchmark
{
    public class TestClass
    {
        public Task<int> MethodA()
        {
            return Task.FromResult(1);
        }

        public async Task<int> MethodB()
        {
            return await Task.FromResult(1);
        }
    }
}