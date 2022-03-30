using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace JsonConvertBenchmark.Deserialize.OneThousandItem;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class JsonDeserializerOneThousandEmployeeBenchmark
{
    private static readonly OneThousandEmployeeJsonDeserializer _employeeDeserializer = new();

    [Benchmark]
    public void NewtonsoftDeserialize()
    {
        var jsonData = _employeeDeserializer.NewtonsoftEmployeeListDeserialize();
    }

    [Benchmark]
    public void SystemTextDeserialize()
    {
        var jsonData = _employeeDeserializer.SystemTextEmployeeListDeserialize();
    }
}