using Newtonsoft.Json;

namespace JsonConvertBenchmark.Serialize.OneHundredItem;

public class OneHundredEmployeeJsonSerializer
{
    private readonly List<Employee> _employees;

    public OneHundredEmployeeJsonSerializer()
    {
        Repository repository = new Repository();

        repository.SeedOneHundredData();

        _employees = repository.GetOneHundredEmployeeList();
    }

    public string NewtonsoftEmployeeListSerialize()
    {
        string json = JsonConvert.SerializeObject(_employees);

        return json;
    }

    public string SystemTextEmployeeListSerialize()
    {
        string json = System.Text.Json.JsonSerializer.Serialize(_employees);

        return json;
    }
}

