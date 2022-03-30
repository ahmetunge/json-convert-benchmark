using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace JsonConvertBenchmark.Serialize.OneHundredItem;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class JsonSerializerOneHundredEmployeeBenchmark
{
    private static readonly OneHundredEmployeeJsonSerializer _employeeSerializer = new OneHundredEmployeeJsonSerializer();

    [Benchmark]
    public void NewtonsoftEmployeeSerialize100Item()
    {
        string jsonData = _employeeSerializer.NewtonsoftEmployeeListSerialize();
    }

    [Benchmark]
    public void SystemTextEmployee100Item()
    {
        string jsonData = _employeeSerializer.SystemTextEmployeeListSerialize();
    }
}