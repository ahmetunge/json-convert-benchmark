using Newtonsoft.Json;

namespace JsonConvertBenchmark.Deserialize.OneHundredItem
{
    public class OneHundredPersonJsonDeserializer
    {
        private readonly string _jsonPersons;

        public OneHundredPersonJsonDeserializer()
        {
            Repository repository = new();

            repository.SeedOneHundredJsonData();

            _jsonPersons = repository.GetOneHundredJsonPersonList();
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
