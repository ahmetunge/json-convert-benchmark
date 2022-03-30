using Newtonsoft.Json;

namespace JsonConvertBenchmark.Serialize.OneHundredItem;

public class OneHundredPersonJsonSerializer
{
    private readonly List<Person> _persons;

    public OneHundredPersonJsonSerializer()
    {
        Repository repository = new();

        repository.SeedOneHundredData();

        _persons = repository.GetOneHundredPersonList();
    }

    public string NewtonsoftPersonListSerialize()
    {
        string json = JsonConvert.SerializeObject(_persons);

        return json;
    }

    public string SystemTextPersonListSerialize()
    {
        string json = System.Text.Json.JsonSerializer.Serialize(_persons);

        return json;
    }
}


