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
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IContactRepository _contactRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepository customerRepository,
            IContactRepository contactRepository,
            ICommentRepository commentRepository,
            IUserRepository userRepository,
            IMapper mapper)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(CustomerListCriteriaModel criteria, int pageIndex = 0, int pageSize = 20)
        {
            var filterSpecification = new CustomerFilterSpecification(userId: criteria.UserId);
            var filterPaginatedSpecification = new CustomerFilterPaginatedSpecification(pageIndex * pageSize, pageSize,
                userId: criteria.UserId);

            var items = await _customerRepository.ListAsync(filterPaginatedSpecification);
            var totalItems = await _customerRepository.CountAsync(filterSpecification);
            
            var model = new CustomerListModel()
            {
                Customers = new PagedResultModel<CustomerListItemModel>()
                {
                    Items = _mapper.Map<IEnumerable<CustomerListItemModel>>(items),
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

                await _customerRepository.CreateAsync(customer);

                return RedirectToAction("Details", new { id = customer.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long id)
        {
            var spec = new CustomerFilterSpecification(id: id);

            var customer = await _customerRepository.SingleAsync(spec);

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
            var customer = await _customerRepository.GetAsync(id);

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
            if (ModelState.IsValid)
            {
                var customer = _mapper.Map<Customer>(model);

                await _customerRepository.UpdateAsync(customer);

                return RedirectToAction("Details", new { id = customer.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            var customer = await _customerRepository.GetAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            await _customerRepository.DeleteAsync(customer);

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
