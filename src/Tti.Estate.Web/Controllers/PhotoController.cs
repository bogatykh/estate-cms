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
    public class PhotoController : Controller
    {
        private readonly IPhotoService _photoService;
        private readonly IPropertyRepository _propertyRepository;
        private readonly IMapper _mapper;

        public PhotoController(IPhotoService photoService, IPropertyRepository propertyRepository, IMapper mapper)
        {
            _photoService = photoService ?? throw new ArgumentNullException(nameof(photoService));
            _propertyRepository = propertyRepository ?? throw new ArgumentNullException(nameof(propertyRepository));
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

            var items = await _photoService.ListAsync(propertyId);

            var model = new PhotoIndexModel()
            {
                PropertyId = propertyId,
                StorageUri = _photoService.GetStorageUri(),
                Photos = _mapper.Map<IEnumerable<PhotoModel>>(items)
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(long propertyId, IFormFile photo)
        {
            await _photoService.CreateAsync(propertyId, photo.OpenReadStream());

            return RedirectToAction(nameof(Index), new { propertyId });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long propertyId, long id)
        {
            await _photoService.DeleteAsync(id);

            return RedirectToAction(nameof(Index), new { propertyId });
        }
    }
}
