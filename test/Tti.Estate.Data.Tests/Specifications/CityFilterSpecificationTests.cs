using System.Collections.Generic;
using System.Linq;
using Tti.Estate.Data.Entities;
using Xunit;

namespace Tti.Estate.Data.Specifications
{
    public class CityFilterSpecificationTests
    {
        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(4, 0)]
        public void ItemsCountTest(long countyId, int expectedCount)
        {
            var target = new CityFilterSpecification(
                countyId: countyId
            );

            var query = GetTestItems()
                .AsQueryable()
                .Where(target.Criteria);

            Assert.Equal(expectedCount, query.Count());
        }

        private List<City> GetTestItems()
        {
            return new List<City>()
            {
                new City() { Id = 1, CountyId = 1, Name = "E" },
                new City() { Id = 2, CountyId = 2, Name = "D" },
                new City() { Id = 3, CountyId = 3, Name = "C" },
                new City() { Id = 4, CountyId = 1, Name = "B" },
                new City() { Id = 5, CountyId = 1, Name = "A" }
            };
        }
    }
}
