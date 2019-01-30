using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Business.Services;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Extensions;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IContactRepository _contactRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService,
            IContactRepository contactRepository,
            ICommentRepository commentRepository,
            IUserRepository userRepository,
            IMapper mapper)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
            _contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(CustomerListCriteriaModel criteria, int pageIndex = 0, int pageSize = 20)
        {
            var customers = await _customerService.ListAsync(pageIndex: pageIndex, pageSize: pageSize,
                userId: criteria.UserId,
                term: criteria.Term
            );

            var model = new CustomerListModel()
            {
                Criteria = (criteria.UserId.HasValue || !string.IsNullOrEmpty(criteria.Term)) ? criteria : null,
                Customers = _mapper.Map<PagedResultModel<CustomerListItemModel>>(customers),
                Users = _mapper.Map<IEnumerable<SelectListItem>>(await _userRepository.ListAsync(new UserFilterSpecification(onlyActive: true)))
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(CustomerListCriteriaModel criteria)
        {
            return RedirectToAction(nameof(Index), criteria);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            CustomerModel model = new CustomerModel()
            {
                UserId = User.GetUserId()
            };

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = _mapper.Map<Customer>(model);

                await _customerService.CreateAsync(customer);

                return RedirectToAction("Details", new { id = customer.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long id)
        {
            var customer = await _customerService.GetAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<CustomerDetailsModel>(customer);

            model.Contacts = _mapper.Map<List<ContactListItemModel>>(await _contactRepository.ListAsync(new ContactFilterSpecification(customerId: id)));
            model.Comments = _mapper.Map<List<CommentListItemModel>>(await _commentRepository.ListAsync(new CommentFilterSpecification(customerId: id)));

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(long id)
        {
            var customer = await _customerService.GetAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<CustomerEditModel>(customer);

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CustomerEditModel model)
        {
            var customer = await _customerService.GetAsync(model.Id);

            if (customer == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _mapper.Map(model, customer);

                await _customerService.UpdateAsync(customer);

                return RedirectToAction("Details", new { id = customer.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _customerService.DeleteAsync(id);

            if (result ==  Business.Dto.OperationResult.NotFound)
            {
                return NotFound();
            }

            return RedirectToAction("Index");
        }

        private async Task PrepareModelAsync(CustomerModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            model.Users = _mapper.Map<IEnumerable<SelectListItem>>(await _userRepository.ListAsync(new UserFilterSpecification(onlyActive: true)));
        }
    }
}
