using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tti.Estate.Business.Services;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Extensions;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionService transactionService,
            ICommentRepository commentRepository,
            IUserRepository userRepository,
            IMapper mapper)
        {
            _transactionService = transactionService ?? throw new ArgumentNullException(nameof(transactionService));
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(TransactionListCriteriaModel criteria, int pageIndex = 0, int pageSize = 20)
        {
            var transactions = await _transactionService.ListAsync(pageIndex: pageIndex, pageSize: pageSize,
                userId: criteria.UserId,
                transactionType: (TransactionType?)criteria.TransactionType,
                status: (TransactionStatus?)criteria.Status,
                dateFrom: criteria.DateFrom,
                dateTo: criteria.DateTo
            );

            var pagedModel = _mapper.Map<PagedResultModel<TransactionListItemModel>>(transactions);

            var model = new TransactionListModel()
            {
                Criteria = (criteria.UserId.HasValue || criteria.TransactionType.HasValue || criteria.Status.HasValue || criteria.DateFrom.HasValue || criteria.DateTo.HasValue) ? criteria : null,
                TotalAmount = pagedModel.Items.Any() ? pagedModel.Items.Sum(x => x.Amount) : (decimal?)null,
                TotalUserAmount = pagedModel.Items.Any() ? pagedModel.Items.Sum(x => x.UserAmount) : (decimal?)null,
                TotalCompanyAmount = pagedModel.Items.Any() ? pagedModel.Items.Sum(x => x.CompanyAmount) : (decimal?)null,
                Transactions = pagedModel,
                Users = _mapper.Map<IEnumerable<SelectListItem>>(await _userRepository.ListAsync(new UserFilterSpecification(onlyActive: true)))
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(TransactionListCriteriaModel criteria)
        {
            return RedirectToAction(nameof(Index), criteria);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TransactionModel model = new TransactionModel()
            {
                UserId = User.GetUserId()
            };

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransactionModel model)
        {
            if (ModelState.IsValid)
            {
                var transaction = _mapper.Map<Transaction>(model);

                await _transactionService.CreateAsync(transaction);

                return RedirectToAction("Details", new { id = transaction.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long id)
        {
            var transaction = await _transactionService.GetAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<TransactionDetailsModel>(transaction);

            model.Comments = _mapper.Map<List<CommentListItemModel>>(await _commentRepository.ListAsync(new CommentFilterSpecification(transactionId: id)));

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(long id)
        {
            var transaction = await _transactionService.GetAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<TransactionEditModel>(transaction);

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TransactionEditModel model)
        {
            var transaction = await _transactionService.GetAsync(model.Id);

            if (transaction == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _mapper.Map(model, transaction);

                await _transactionService.UpdateAsync(transaction);

                return RedirectToAction("Details", new { id = transaction.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _transactionService.DeleteAsync(id);

            if (result == Business.Dto.OperationResult.NotFound)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Submit(long id)
        {
            var result = await _transactionService.SubmitAsync(id);

            if (result == Business.Dto.OperationResult.NotFound)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Details), new { id });
        }

        [Authorize(Policy = PolicyConstants.TransactionApproval)]
        [HttpPost]
        public async Task<IActionResult> Approve(long id)
        {
            var result = await _transactionService.ApproveAsync(id);

            if (result == Business.Dto.OperationResult.NotFound)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Details), new { id });
        }

        [Authorize(Policy = PolicyConstants.TransactionApproval)]
        [HttpPost]
        public async Task<IActionResult> Reject(long id)
        {
            var result = await _transactionService.RejectAsync(id);

            if (result == Business.Dto.OperationResult.NotFound)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Details), new { id });
        }

        private async Task PrepareModelAsync(TransactionModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            model.Users = _mapper.Map<IEnumerable<SelectListItem>>(await _userRepository.ListAsync(new UserFilterSpecification(onlyActive: true)));
        }
    }
}
