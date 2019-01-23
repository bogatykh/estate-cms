using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(int pageIndex = 0, int pageSize = 20)
        {
            var filterSpecification = new UserFilterSpecification();
            var filterPaginatedSpecification = new UserFilterPaginatedSpecification(pageIndex * pageSize, pageSize);

            var items = await _userRepository.ListAsync(filterPaginatedSpecification);
            var totalItems = await _userRepository.CountAsync(filterSpecification);

            var model = new UserListModel()
            {
                Users = new PagedResultModel<UserListItemModel>()
                {
                    Items = _mapper.Map<IEnumerable<UserListItemModel>>(items),
                    PageIndex = pageIndex,
                    TotalItems = totalItems,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize)
                }
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = _mapper.Map<User>(model);

                await _userRepository.CreateAsync(customer);

                return RedirectToAction("Details", new { id = customer.Id });
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long id)
        {
            var customer = await _userRepository.GetAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<UserDetailsModel>(customer);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(long id)
        {
            var customer = await _userRepository.GetAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<UserEditModel>(customer);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserEditModel model)
        {
            if (ModelState.IsValid)
            {
                var customer = _mapper.Map<User>(model);

                await _userRepository.UpdateAsync(customer);

                return RedirectToAction("Details", new { id = customer.Id });
            }

            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            var customer = await _userRepository.GetAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            await _userRepository.DeleteAsync(customer);

            return RedirectToAction("Index");
        }
    }
}
