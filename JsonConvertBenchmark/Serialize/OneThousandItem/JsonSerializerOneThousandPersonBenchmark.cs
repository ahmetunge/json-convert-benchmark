using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace JsonConvertBenchmark.Serialize.OneThousandItem
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class JsonSerializerOneThousandPersonBenchmark
    {
        private static readonly OneThousandPersonJsonSerializer _personSerializer = new();

        [Benchmark]
        public void NewtonsoftPersonSerialize1000Item()
        {
            string jsonData = _personSerializer.NewtonsoftPersonListSerialize();
        }

        [Benchmark]
        public void SystemTextPerson1000Item()
        {
            string jsonData = _personSerializer.SystemTextPersonListSerialize();
        }
    }
}
