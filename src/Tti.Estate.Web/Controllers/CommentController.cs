using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Extensions;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentController(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create(long? customerId, long? propertyId, long? transactionId)
        {
            CommentModel model = new CommentModel()
            {
                CustomerId = customerId,
                PropertyId = propertyId,
                TransactionId = transactionId
            };

            if (!customerId.HasValue && !propertyId.HasValue && !transactionId.HasValue)
            {
                return BadRequest();
            }

            if (Request.IsAjaxRequest())
            {
                return PartialView(model);
            }
            else
            {
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommentModel model)
        {
            if (ModelState.IsValid)
            {
                var comment = _mapper.Map<Comment>(model);

                comment.UserId = User.GetUserId();

                await _commentRepository.CreateAsync(comment);

                if (model.TransactionId.HasValue)
                {
                    return RedirectToAction("Details", "Transaction", new { id = model.TransactionId.Value });
                }
                else if (model.PropertyId.HasValue)
                {
                    return RedirectToAction("Details", "Property", new { id = model.PropertyId.Value });
                }
                else if (model.CustomerId.HasValue)
                {
                    return RedirectToAction("Details", "Customer", new { id = model.CustomerId.Value });
                }
            }
            
            if (Request.IsAjaxRequest())
            {
                return PartialView(model);
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IEnumerable<CommentListItemModel>> GetData(CommentListRequestModel requestModel)
        {
            var spec = _mapper.Map<CommentFilterSpecification>(requestModel);

            var data = await _commentRepository.ListAsync(spec);

            return _mapper.Map<IEnumerable<CommentListItemModel>>(data);
        }
    }
}
