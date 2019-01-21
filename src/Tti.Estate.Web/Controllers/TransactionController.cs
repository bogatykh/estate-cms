using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class TransactionController : Controller
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionRepository transactionRepository, IUserRepository userRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        
        [HttpGet]
        public async Task<IActionResult> Index(int pageIndex = 0, int pageSize = 20)
        {
            var spec = new TransactionFilterPaginatedSpecification(pageIndex * pageSize, pageSize);

            var items = await _transactionRepository.ListAsync(spec);
            var totalItems = await _transactionRepository.CountAsync(spec);

            var model = new TransactionListModel()
            {
                Transactions = new PagedResultModel<TransactionListItemModel>()
                {
                    Items = _mapper.Map<IEnumerable<TransactionListItemModel>>(items),
                    PageIndex = pageIndex,
                    TotalItems = totalItems,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize)
                }
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
            var transaction = await _transactionRepository.GetAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<TransactionDetailsModel>(transaction);

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
