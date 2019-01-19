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
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepository customerRepository, IUserRepository userRepository, IMapper mapper)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
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
            var customer = await _customerRepository.GetAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<CustomerDetailsModel>(customer);

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

        [HttpGet]
        public async Task<DataTableModel<CustomerListItemModel>> GetData(DataTableRequestModel requestModel)
        {
            var data = await _customerRepository.SearchAsync();

            var model = _mapper.Map<DataTableModel<CustomerListItemModel>>(data);

            model.DrawCounter = requestModel.DrawCounter;

            return model;
        }
    }
}
