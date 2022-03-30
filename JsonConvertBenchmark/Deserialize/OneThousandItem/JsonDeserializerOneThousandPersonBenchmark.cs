using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace JsonConvertBenchmark.Deserialize.OneThousandItem
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class JsonDeserializerOneThousandPersonBenchmark
    {
        private static readonly OneThousandPersonJsonDeserializer _personDeserializer = new();

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
