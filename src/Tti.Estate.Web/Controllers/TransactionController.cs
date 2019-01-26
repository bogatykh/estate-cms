using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Extensions;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionRepository transactionRepository,
            ICommentRepository commentRepository,
            IUserRepository userRepository,
            IMapper mapper)
        {
            _transactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(TransactionListCriteriaModel criteria, int pageIndex = 0, int pageSize = 20)
        {
            var filterSpecification = new TransactionFilterSpecification(userId: criteria.UserId);
            var filterPaginatedSpecification = new TransactionFilterPaginatedSpecification(pageIndex * pageSize, pageSize,
                userId: criteria.UserId);

            var items = await _transactionRepository.ListAsync(filterPaginatedSpecification);
            var totalItems = await _transactionRepository.CountAsync(filterSpecification);

            var modelItems = _mapper.Map<IEnumerable<TransactionListItemModel>>(items);

            var model = new TransactionListModel()
            {
                TotalAmount = modelItems.Any() ? modelItems.Sum(x => x.Amount) : (decimal?)null,
                TotalUserAmount = modelItems.Any() ? modelItems.Sum(x => x.UserAmount) : (decimal?)null,
                TotalCompanyAmount = modelItems.Any() ? modelItems.Sum(x => x.CompanyAmount) : (decimal?)null,
                Transactions = new PagedResultModel<TransactionListItemModel>()
                {
                    Items = modelItems,
                    PageIndex = pageIndex,
                    TotalItems = totalItems,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize)
                },
                Users = _mapper.Map<IEnumerable<SelectListItem>>(await _userRepository.ListAsync(new UserFilterSpecification(onlyActive: true)))
            };

            return View(model);
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

                await _transactionRepository.CreateAsync(transaction);

                return RedirectToAction("Details", new { id = transaction.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long id)
        {
            var spec = new TransactionFilterSpecification(id: id);

            var transaction = await _transactionRepository.SingleAsync(spec);

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
            var transaction = await _transactionRepository.GetAsync(id);

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
            if (ModelState.IsValid)
            {
                var transaction = _mapper.Map<Transaction>(model);

                await _transactionRepository.UpdateAsync(transaction);

                return RedirectToAction("Details", new { id = transaction.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            await _transactionRepository.DeleteAsync(transaction);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> PassToApprove(long id)
        {
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            transaction.Status = TransactionStatus.Approving;

            await _transactionRepository.UpdateAsync(transaction);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Approve(long id)
        {
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            transaction.Status = TransactionStatus.Approved;

            await _transactionRepository.UpdateAsync(transaction);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        public async Task<IActionResult> Reject(long id)
        {
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            transaction.Status = TransactionStatus.Draft;

            await _transactionRepository.UpdateAsync(transaction);

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
