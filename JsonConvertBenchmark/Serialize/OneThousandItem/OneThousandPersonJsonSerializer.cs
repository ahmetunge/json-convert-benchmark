using Newtonsoft.Json;

namespace JsonConvertBenchmark.Serialize.OneThousandItem
{
    internal class OneThousandPersonJsonSerializer
    {
        private readonly List<Person> _persons;

        public OneThousandPersonJsonSerializer()
        {
            Repository repository = new();

            repository.SeedOneThousandData();

            _persons = repository.GetOneThousandPersonList();
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
}
