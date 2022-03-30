using Newtonsoft.Json;

namespace JsonConvertBenchmark.Deserialize.OneThousandItem
{
    internal class OneThousandPersonJsonDeserializer
    {
        private readonly string _jsonPersons;

        public OneThousandPersonJsonDeserializer()
        {
            Repository repository = new();

            repository.SeedOneThousandJsonData();

            _jsonPersons = repository.GetOneThousandJsonPersonList();
        }

        public List<Person> NewtonsoftPersonListDeserialize()
        {
            var persons = JsonConvert.DeserializeObject<List<Person>>(_jsonPersons);

            return persons;
        }

        public List<Person> SystemTextPersonListDeserialize()
        {
            var persons = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(_jsonPersons);

            return persons;
        }
    }
}
