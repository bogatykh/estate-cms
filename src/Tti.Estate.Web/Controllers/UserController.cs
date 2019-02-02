using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Exceptions;
using Tti.Estate.Business.Services;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    [Authorize(Policy = PolicyConstants.UserManagement)]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(int pageIndex = 0, int pageSize = 20)
        {
            var users = await _userService.ListAsync(pageIndex: pageIndex, pageSize: pageSize);

            var model = new UserListModel()
            {
                Users = _mapper.Map<PagedResultModel<UserListItemModel>>(users)
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
                var user = _mapper.Map<User>(model);
                
                try
                {
                    await _userService.CreateAsync(user, string.Empty);

                    return RedirectToAction(nameof(Details), new { id = user.Id });
                }
                catch (DomainException e)
                {
                    ModelState.TryAddModelError("", e.Message);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long id)
        {
            var user = await _userService.GetAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<UserDetailsModel>(user);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(long id)
        {
            var user = await _userService.GetAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<UserEditModel>(user);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserEditModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<User>(model);

                await _userService.UpdateAsync(user);

                return RedirectToAction(nameof(Details), new { id = user.Id });
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                var result = await _userService.DeleteAsync(id);

                if (result == Business.Dto.OperationResult.NotFound)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Details), new { id });
            }
            catch (DomainException e)
            {
                ModelState.TryAddModelError("", e.Message);
            }

            var user = await _userService.GetAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<UserDetailsModel>(user);

            return View(nameof(Details), model);
        }

        [HttpPost]
        public async Task<IActionResult> Block(long id)
        {
            try
            {
                var result = await _userService.BlockAsync(id);

                if (result == Business.Dto.OperationResult.NotFound)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Details), new { id });
            }
            catch (DomainException e)
            {
                ModelState.TryAddModelError("", e.Message);
            }

            var user = await _userService.GetAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<UserDetailsModel>(user);

            return View(nameof(Details), model);
        }

        [HttpPost]
        public async Task<IActionResult> Unblock(long id)
        {
            try
            {
                var result = await _userService.UnblockAsync(id);

                if (result == Business.Dto.OperationResult.NotFound)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Details), new { id });
            }
            catch (DomainException e)
            {
                ModelState.TryAddModelError("", e.Message);
            }

            var user = await _userService.GetAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<UserDetailsModel>(user);

            return View(nameof(Details), model);
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword(long id)
        {
            var user = await _userService.GetAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var model = new ChangePasswordModel()
            {
                UserId = id
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
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userService.ChangePasswordAsync(model.UserId, model.Password);

                if (result == Business.Dto.OperationResult.NotFound)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Details), new { id = model.UserId });
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
