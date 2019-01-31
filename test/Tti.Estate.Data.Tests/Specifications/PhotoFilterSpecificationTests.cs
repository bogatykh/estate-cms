using System.Collections.Generic;
using System.Linq;
using Tti.Estate.Data.Entities;
using Xunit;

namespace Tti.Estate.Data.Specifications
{
    public class PhotoFilterSpecificationTests
    {
        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(4, 0)]
        public void ItemsCountTest(long propertyId, int expectedCount)
        {
            var target = new PhotoFilterSpecification(
                propertyId: propertyId
            );

            var query = GetTestItems()
                .AsQueryable()
                .Where(target.Criteria);

            Assert.Equal(expectedCount, query.Count());
        }

        private List<Photo> GetTestItems()
        {
            return new List<Photo>()
            {
                new Photo() { Id = 1, PropertyId = 1 },
                new Photo() { Id = 2, PropertyId = 2 },
                new Photo() { Id = 3, PropertyId = 3 },
                new Photo() { Id = 4, PropertyId = 1 },
                new Photo() { Id = 5, PropertyId = 1 }
            };
        }
    }
}
