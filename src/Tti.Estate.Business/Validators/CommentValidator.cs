using Microsoft.Extensions.Localization;
using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Exceptions;
using Tti.Estate.Business.Specifications;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Business.Validators
{
    internal class CommentValidator : ICommentValidator
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IStringLocalizer _localizer;

        public CommentValidator(ICommentRepository commentRepository, IStringLocalizer<CommentValidator> localizer)
        {
            _commentRepository = commentRepository;
            _localizer = localizer;
        }

        public async Task ValidateAsync(Comment entity, CommentAction action)
        {
            switch (action)
            {
                case CommentAction.Create:
                    await ValidateCreateAsync(entity);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private async Task ValidateCreateAsync(Comment entity)
        {
            var spec = new CommentHasCustomerSpecification()
                .Or(new CommentHasPropertySpecification())
                .Or(new CommentHasTransactionSpecification());

            if (!await spec.IsSatisfiedByAsync(entity))
            {
                throw new DomainException(_localizer.GetString("UnrelatedComment"));
            }
        }
    }
}
