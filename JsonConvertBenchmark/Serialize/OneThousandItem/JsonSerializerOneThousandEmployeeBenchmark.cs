using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace JsonConvertBenchmark.Serialize.OneThousandItem;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class JsonSerializerOneThousandEmployeeBenchmark
{
    private static readonly OneThousandEmployeeJsonSerializer _employeeSerializer = new();

    [Benchmark]
    public void NewtonsoftEmployeeSerializeThousandItem()
    {
        string jsonData = _employeeSerializer.NewtonsoftEmployeeListSerialize();
    }

    [Benchmark]
    public void SystemTextEmployeeThousandItem()
    {
        string jsonData = _employeeSerializer.SystemTextEmployeeListSerialize();
    }
}