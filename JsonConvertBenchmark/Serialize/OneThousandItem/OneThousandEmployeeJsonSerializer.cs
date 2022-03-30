using Newtonsoft.Json;

namespace JsonConvertBenchmark.Serialize.OneThousandItem
{
    internal class OneThousandEmployeeJsonSerializer
    {
        private readonly List<Employee> _employees;

        public OneThousandEmployeeJsonSerializer()
        {
            Repository repository = new Repository();

            repository.SeedOneThousandData();

            _employees = repository.GetThousandEmployeeList();
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
}
