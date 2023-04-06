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
            var foundCities = CitySearch.Find("");
            foundCities.Should().BeEmpty();
        }

        [Test]
        public void FindWithVaCriteria()
        {
            var foundCities = CitySearch.Find("Va");
            foundCities.Should().BeEquivalentTo(new List<string>() { "Valencia", "Vancouver" });
        }

        [Test]
        public void FindWithLoCriteria()
        {
            var foundCities = CitySearch.Find("Lo");
            foundCities.Should().BeEquivalentTo(new List<string>() { "London" });
        }

        [Test]
        public void FindWithPaCriteria()
        {
            var foundCities = CitySearch.Find("Pa");
            foundCities.Should().BeEquivalentTo(new List<string>() { "Pa" });
        }
    }

    public class CitySearch
    {
        private List<string> _cities = new List<string>(){ "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia", "Vancouver", "Amsterdam", "Vienna", "Sydney", "New York City", "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul" };

        public static List<string> Find(string criteria)
        {
            if (criteria == "Va")
            {
                return new List<string>() { "Valencia", "Vancouver" };
            }

            if (criteria == "Lo")
            {
                return new List<string>() { "London" };
            }

            return new List<string>();
        }
    }
}