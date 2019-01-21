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
    public class PropertyController : Controller
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public PropertyController(IPropertyRepository propertyRepository, IUserRepository userRepository, IMapper mapper)
        {
            _propertyRepository = propertyRepository ?? throw new ArgumentNullException(nameof(propertyRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(PropertyListCriteriaModel criteria, int pageIndex = 0, int pageSize = 20)
        {
            var spec = new PropertyFilterPaginatedSpecification(pageIndex * pageSize, pageSize,
                userId: criteria.UserId);

            var items = await _propertyRepository.ListAsync(spec);
            var totalItems = await _propertyRepository.CountAsync(spec);

            var model = new PropertyListModel()
            {
                Criteria = criteria,
                Properties = new PagedResultModel<PropertyListItemModel>()
                {
                    Items = _mapper.Map<IEnumerable<PropertyListItemModel>>(items),
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
            PropertyModel model = new PropertyModel()
            {
                UserId = User.GetUserId()
            };

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PropertyModel model)
        {
            if (ModelState.IsValid)
            {
                var property = _mapper.Map<Property>(model);

                await _propertyRepository.CreateAsync(property);

                return RedirectToAction("Details", new { id = property.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long id)
        {
            var property = await _propertyRepository.GetAsync(id);

            if (property == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<PropertyDetailsModel>(property);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(long id)
        {
            var property = await _propertyRepository.GetAsync(id);

            if (property == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<PropertyEditModel>(property);

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(PropertyEditModel model)
        {
            if (ModelState.IsValid)
            {
                var property = _mapper.Map<Property>(model);

                await _propertyRepository.UpdateAsync(property);

                return RedirectToAction("Details", new { id = property.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            var property = await _propertyRepository.GetAsync(id);

            if (property == null)
            {
                return NotFound();
            }

            await _propertyRepository.DeleteAsync(property);

            return RedirectToAction("Index");
        }

        private async Task PrepareModelAsync(PropertyModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            model.Users = _mapper.Map<IEnumerable<SelectListItem>>(await _userRepository.ListAsync(new UserFilterSpecification(onlyActive: true)));
        }
    }
}
