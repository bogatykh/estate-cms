using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Business.Services;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    [Route("Property/{propertyId:long}/Photos/[action]")]
    public class PropertyPhotoController : Controller
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IPropertyPhotoService _propertyPhotoService;
        private readonly IMapper _mapper;

        public PropertyPhotoController(IPropertyRepository propertyRepository, IPropertyPhotoService propertyPhotoService, IMapper mapper)
        {
            _propertyRepository = propertyRepository ?? throw new ArgumentNullException(nameof(propertyRepository));
            _propertyPhotoService = propertyPhotoService ?? throw new ArgumentNullException(nameof(propertyPhotoService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(long propertyId)
        {
            var property = await _propertyRepository.GetAsync(propertyId);

            if (property == null)
            {
                return NotFound();
            }

            var items = await _propertyPhotoService.ListAsync(propertyId);

            var model = new PropertyPhotoIndexModel()
            {
                PropertyId = propertyId,
                StorageUri = _propertyPhotoService.GetStorageUri(),
                Photos = _mapper.Map<IEnumerable<PropertyPhotoModel>>(items)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(long propertyId, IFormFile photo)
        {
            await _propertyPhotoService.CreateAsync(propertyId, photo.OpenReadStream());

            return RedirectToAction(nameof(Index), new { propertyId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long propertyId, long id)
        {
            await _propertyPhotoService.DeleteAsync(id);

            return RedirectToAction(nameof(Index), new { propertyId });
        }
    }
}
