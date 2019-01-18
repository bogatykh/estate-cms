using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
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
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            PropertyModel model = new PropertyModel();

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

        [HttpGet]
        public async Task<DataTableModel<PropertyListItemModel>> GetData(DataTableRequestModel requestModel)
        {
            var data = await _propertyRepository.SearchAsync();

            var model = _mapper.Map<DataTableModel<PropertyListItemModel>>(data);

            model.DrawCounter = requestModel.DrawCounter;

            return model;
        }
    }
}
