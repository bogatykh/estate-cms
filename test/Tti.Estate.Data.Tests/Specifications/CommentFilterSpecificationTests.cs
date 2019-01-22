using System.Collections.Generic;
using System.Linq;
using Tti.Estate.Data.Entities;
using Xunit;

namespace Tti.Estate.Data.Specifications
{
    public class CommentFilterSpecificationTests
    {
        [Theory]
        [InlineData(null, null, null, 1)]
        [InlineData(null, 2, null, 1)]
        [InlineData(null, null, 3, 1)]
        [InlineData(1, 2, 3, 2)]
        [InlineData(1, null, null, 0)]
        [InlineData(null, 3, null, 0)]
        public void ItemsCountTest(long? customerId, long? propertyId, long? transactionId, int expectedCount)
        {
            var target = new CommentFilterSpecification(
                customerId: customerId,
                propertyId: propertyId,
                transactionId: transactionId
            );

            var query = GetTestItems()
                .AsQueryable()
                .Where(target.Criteria);

            Assert.Equal(expectedCount, query.Count());
        }

        private List<Comment> GetTestItems()
        {
            return new List<Comment>()
            {
                new Comment() { Id = 1, UserId = 1, CustomerId = null, PropertyId = null, TransactionId = null },
                new Comment() { Id = 2, UserId = 2, CustomerId = 1, PropertyId = 2, TransactionId = 3 },
                new Comment() { Id = 3, UserId = 1, CustomerId = 1, PropertyId = 2, TransactionId = 3 },
                new Comment() { Id = 4, UserId = 1, CustomerId = null, PropertyId = 2, TransactionId = null },
                new Comment() { Id = 5, UserId = 2, CustomerId = null, PropertyId = null, TransactionId = 3 }
            };
        }
    }
}
