using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace JsonConvertBenchmark.Serialize.OneHundredItem;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class JsonSerializerOneHundredPersonBenchmark
{
    private static readonly OneHundredPersonJsonSerializer _personSerializer = new();

    [Benchmark]
    public void NewtonsoftPersonSerializeOneHundredItem()
    {
        string jsonData = _personSerializer.NewtonsoftPersonListSerialize();
    }

    [Benchmark]
    public void SystemTextPersonOneHundredItem()
    {
        string jsonData = _personSerializer.SystemTextPersonListSerialize();
    }
}

