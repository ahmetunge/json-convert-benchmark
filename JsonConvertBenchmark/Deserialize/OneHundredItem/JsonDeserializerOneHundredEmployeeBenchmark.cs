using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace JsonConvertBenchmark.Deserialize.OneHundredItem;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class JsonDeserializerOneHundredEmployeeBenchmark
{
    private static readonly OneHundredEmployeeJsonDeserializer _employeeDeserializer = new();

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