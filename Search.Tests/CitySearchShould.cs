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
    }

    public class CitySearch
    {
        private List<string> _cities = new List<string>(){ "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia", "Vancouver", "Amsterdam", "Vienna", "Sydney", "New York City", "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul" };

        public static List<string> Find(string criteria)
        {
            return new List<string>();
        }
    }
}