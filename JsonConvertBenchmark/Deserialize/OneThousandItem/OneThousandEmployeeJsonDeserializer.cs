using Newtonsoft.Json;

namespace JsonConvertBenchmark.Deserialize.OneThousandItem
{
    public class OneThousandEmployeeJsonDeserializer
    {
        private readonly string _jsonEmployees;

        public OneThousandEmployeeJsonDeserializer()
        {
            Repository repository = new();

            repository.SeedOneThousandJsonData();

            _jsonEmployees = repository.GetOneThousandJsonEmployeeList();
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
}
