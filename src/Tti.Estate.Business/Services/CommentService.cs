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
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICommentValidator _commentValidator;
        private readonly IIdentityService _identityService;

        public CommentService(ICommentRepository commentRepository, IUnitOfWork unitOfWork, ICommentValidator commentValidator, IIdentityService identityService)
        {
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
            _commentValidator = commentValidator;
            _identityService = identityService;
        }

        public async Task CreateAsync(Comment comment)
        {
            await _commentValidator.ValidateAsync(comment, CommentAction.Create);

            comment.UserId = _identityService.GetUserId();

            _commentRepository.Create(comment);

            await _unitOfWork.SaveAsync();
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
