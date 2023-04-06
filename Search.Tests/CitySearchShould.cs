using FluentAssertions;

namespace Search.Tests
{
    public class CitySearchShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindEmptyCriteria()
        {
            var foundCities = new CitySearch().Find("");
            foundCities.Should().BeEmpty();
        }

        [Test]
        public void FindWithVaCriteria()
        {
            var foundCities = new CitySearch().Find("Va");
            foundCities.Should().BeEquivalentTo(new List<string>() { "Valencia", "Vancouver" });
        }

        [Test]
        public void FindWithLoCriteria()
        {
            var foundCities = new CitySearch().Find("Lo");
            foundCities.Should().BeEquivalentTo(new List<string>() { "London" });
        }

        [Test]
        public void FindWithPaCriteria()
        {
            var foundCities = new CitySearch().Find("Pa");
            foundCities.Should().BeEquivalentTo(new List<string>() { "Paris" });
        }

        [Test]
        public void FindWithPACriteria()
        {
            var foundCities = new CitySearch().Find("PA");
            foundCities.Should().BeEquivalentTo(new List<string>() { "Paris" });
        }

        [Test]
        public void FindWithApeCriteria()
        {
            var foundCities = new CitySearch().Find("ape");
            foundCities.Should().BeEquivalentTo(new List<string>() { "Budapest" });
        }
    }

    public class CitySearch
    {
        private readonly List<string> _cities = new List<string>(){ "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia", "Vancouver", "Amsterdam", "Vienna", "Sydney", "New York City", "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul" };

        public List<string> Find(string criteria)
        {
            if (criteria.Length >= 2)
            {
                return this._cities
                    .Where(c => c.Contains(criteria, StringComparison.InvariantCultureIgnoreCase))
                    .ToList();
            }

            return new List<string>();
        }
    }
}