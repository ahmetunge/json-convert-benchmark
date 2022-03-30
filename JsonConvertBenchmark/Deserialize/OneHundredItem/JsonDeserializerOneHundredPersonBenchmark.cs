using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace JsonConvertBenchmark.Deserialize.OneHundredItem
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class JsonDeserializerOneHundredPersonBenchmark
    {
        private static readonly OneHundredPersonJsonDeserializer _personDeserializer = new();

        [Benchmark]
        public void NewtonsoftDeserialize()
        {
            var jsonData = _personDeserializer.NewtonsoftPersonListDeserialize();
        }

        [Benchmark]
        public void SystemTextDeserialize()
        {
            var jsonData = _personDeserializer.SystemTextPersonListDeserialize();
        }
    }
}
