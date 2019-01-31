using System.Collections.Generic;
using System.Linq;
using Tti.Estate.Data.Entities;
using Xunit;

namespace Tti.Estate.Data.Specifications
{
    public class ContactFilterSpecificationTests
    {
        [Theory]
        [InlineData(null, null, 2)]
        [InlineData(null, 2, 1)]
        [InlineData(1, 2, 2)]
        [InlineData(1, null, 0)]
        [InlineData(null, 3, 0)]
        public void ItemsCountTest(long? customerId, long? propertyId, int expectedCount)
        {
            var target = new ContactFilterSpecification(
                customerId: customerId,
                propertyId: propertyId
            );

            var query = GetTestItems()
                .AsQueryable()
                .Where(target.Criteria);

            Assert.Equal(expectedCount, query.Count());
        }

        private List<Contact> GetTestItems()
        {
            return new List<Contact>()
            {
                new Contact() { Id = 1, CustomerId = null, PropertyId = null },
                new Contact() { Id = 2, CustomerId = 1, PropertyId = 2 },
                new Contact() { Id = 3, CustomerId = 1, PropertyId = 2 },
                new Contact() { Id = 4, CustomerId = null, PropertyId = 2 },
                new Contact() { Id = 5, CustomerId = null, PropertyId = null }
            };
        }
    }
}
