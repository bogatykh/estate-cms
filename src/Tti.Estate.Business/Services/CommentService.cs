using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Business.Validators;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Services;

namespace Tti.Estate.Business.Services
{
    internal class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly ICommentValidator _commentValidator;
        private readonly IIdentityService _identityService;

        public CommentService(ICommentRepository commentRepository, ICommentValidator commentValidator, IIdentityService identityService)
        {
            _commentRepository = commentRepository;
            _commentValidator = commentValidator;
            _identityService = identityService;
        }

        public async Task CreateAsync(Comment comment)
        {
            await _commentValidator.ValidateAsync(comment, CommentAction.Create);

            comment.UserId = _identityService.GetUserId();

            await _commentRepository.CreateAsync(comment);
        }

        public async Task<IEnumerable<Comment>> ListAsync(long? customerId = null, long? propertyId = null, long? transactionId = null)
        {
            var spec = new CommentFilterSpecification(
                customerId: customerId,
                propertyId: propertyId,
                transactionId: transactionId
            );

            return await _commentRepository.ListAsync(spec);
        }
    }
}
