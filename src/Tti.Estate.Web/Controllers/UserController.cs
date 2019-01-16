using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
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
        public IActionResult Index()
        {
            return View();
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

        [HttpGet]
        public async Task<DataTableModel<UserListItemModel>> GetData(DataTableRequestModel requestModel)
        {
            var data = await _userRepository.SearchAsync();

            var model = _mapper.Map<DataTableModel<UserListItemModel>>(data);

            model.DrawCounter = requestModel.DrawCounter;

            return model;
        }
    }
}
