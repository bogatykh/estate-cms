using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Services;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService ?? throw new ArgumentNullException(nameof(commentService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(long? customerId, long? propertyId, long? transactionId)
        {
            if (!customerId.HasValue && !propertyId.HasValue && !transactionId.HasValue)
            {
                return BadRequest();
            }

            CommentModel model = new CommentModel()
            {
                CustomerId = customerId,
                PropertyId = propertyId,
                TransactionId = transactionId
            };

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

                await _commentService.CreateAsync(comment);

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
    }
}
