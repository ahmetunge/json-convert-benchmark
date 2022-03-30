using Bogus;
using Microsoft.Extensions.Caching.Memory;
using System.Text.Json;

namespace JsonConvertBenchmark
{
    public class Repository
    {
        private MemoryCache _cache;

        public Repository()
        {
            _cache = new MemoryCache(new MemoryCacheOptions());
        }

        private void SeedData(int count, string personCacheKey, string employeeCacheKey)
        {
            List<Person> persons = new Faker<Person>()
                .RuleFor(x => x.Id, f => f.Random.Int())
                .RuleFor(x => x.DateOfBirth, f => f.Date.Past())
                .RuleFor(x => x.Firstname, f => f.Person.FirstName)
                .RuleFor(x => x.Lastname, f => f.Person.LastName)
                .Generate(count);

            _cache.Set(personCacheKey, persons);

            List<Employee> employees = new Faker<Employee>()
                .RuleFor(x => x.Id, f => f.Random.Int())
                .RuleFor(x => x.DateOfBirth, f => f.Date.Past())
                .RuleFor(x => x.Firstname, f => f.Person.FirstName)
                .RuleFor(x => x.Lastname, f => f.Person.LastName)
                .RuleFor(x => x.FatherName, f => f.Person.FirstName)
                .RuleFor(x => x.MotherName, f => f.Person.FirstName)
                .RuleFor(x => x.Age, f => f.Random.Int(18, 100))
                .RuleFor(x => x.CitizenshipNumber, f => f.Random.String2(11))
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.IpAddress, f => f.Random.String2(8))
                .RuleFor(x => x.IsDeleted, false)
                .RuleFor(x => x.NationalityId, f => f.Random.Int(1))
                .RuleFor(x => x.PhoneNumber, f => f.Person.Phone)
                .Generate(count);

            _cache.Set(employeeCacheKey, employees);
        }

        private void SeedJsonData(int count, string personCacheKey, string employeeCacheKey)
        {
            List<Person> persons = new Faker<Person>()
                .RuleFor(x => x.Id, f => f.Random.Int())
                .RuleFor(x => x.DateOfBirth, f => f.Date.Past())
                .RuleFor(x => x.Firstname, f => f.Person.FirstName)
                .RuleFor(x => x.Lastname, f => f.Person.LastName)
                .Generate(count);

            _cache.Set(personCacheKey, JsonSerializer.Serialize(persons));

            List<Employee> employees = new Faker<Employee>()
                .RuleFor(x => x.Id, f => f.Random.Int())
                .RuleFor(x => x.DateOfBirth, f => f.Date.Past())
                .RuleFor(x => x.Firstname, f => f.Person.FirstName)
                .RuleFor(x => x.Lastname, f => f.Person.LastName)
                .RuleFor(x => x.FatherName, f => f.Person.FirstName)
                .RuleFor(x => x.MotherName, f => f.Person.FirstName)
                .RuleFor(x => x.Age, f => f.Random.Int(18, 100))
                .RuleFor(x => x.CitizenshipNumber, f => f.Random.String2(11))
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.IpAddress, f => f.Random.String2(8))
                .RuleFor(x => x.IsDeleted, false)
                .RuleFor(x => x.NationalityId, f => f.Random.Int(1))
                .RuleFor(x => x.PhoneNumber, f => f.Person.Phone)
                .Generate(count);

            _cache.Set(employeeCacheKey, JsonSerializer.Serialize(employees));
        }

        public List<Person> GetOneHundredPersonList()
        {
            return _cache.Get<List<Person>>(CacheKeys.OneHundredPersonList);
        }

        public List<Employee> GetOneHundredEmployeeList()
        {
            return _cache.Get<List<Employee>>(CacheKeys.OneHundredEmployeeList);
        }

        public List<Person> GetOneThousandPersonList()
        {
            return _cache.Get<List<Person>>(CacheKeys.OneThousandPersonList);
        }

        public List<Employee> GetThousandEmployeeList()
        {
            return _cache.Get<List<Employee>>(CacheKeys.OneThousandEmployeeList);
        }

        public string GetOneHundredJsonPersonList()
        {
            return _cache.Get<string>(CacheKeys.OneHundredJsonPersonList);
        }

        public string GetOneHundredJsonEmployeeList()
        {
            return _cache.Get<string>(CacheKeys.OneHundredJsonEmployeeList);
        }

        public string GetOneThousandJsonPersonList()
        {
            return _cache.Get<string>(CacheKeys.OneThousandJsonPersonList);
        }

        public string GetOneThousandJsonEmployeeList()
        {
            return _cache.Get<string>(CacheKeys.OneThousandJsonEmployeeList);
        }

        public void SeedOneHundredData()
        {
            SeedData(100, CacheKeys.OneHundredPersonList, CacheKeys.OneHundredEmployeeList);
        }

        public void SeedOneHundredJsonData()
        {
            SeedJsonData(100, CacheKeys.OneHundredJsonPersonList, CacheKeys.OneHundredJsonEmployeeList);
        }

        public void SeedOneThousandJsonData()
        {
            SeedJsonData(1000, CacheKeys.OneThousandJsonPersonList, CacheKeys.OneThousandJsonEmployeeList);
        }

        public void SeedOneThousandData()
        {
            SeedData(1000, CacheKeys.OneThousandPersonList, CacheKeys.OneThousandEmployeeList);
        }
    }
}

