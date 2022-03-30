using Newtonsoft.Json;

namespace JsonConvertBenchmark.Deserialize.OneHundredItem;

public class OneHundredEmployeeJsonDeserializer
{
    private readonly string _jsonEmployees;

    public OneHundredEmployeeJsonDeserializer()
    {
        Repository repository = new();

        repository.SeedOneHundredJsonData();

        _jsonEmployees = repository.GetOneHundredJsonEmployeeList();
    }

    public List<Employee> NewtonsoftEmployeeListDeserialize()
    {
        var employees = JsonConvert.DeserializeObject<List<Employee>>(_jsonEmployees);

        return employees;
    }

    public List<Employee> SystemTextEmployeeListDeserialize()
    {
        var employees = System.Text.Json.JsonSerializer.Deserialize<List<Employee>>(_jsonEmployees);

        return employees;
    }
}