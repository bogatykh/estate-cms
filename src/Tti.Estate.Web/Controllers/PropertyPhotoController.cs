using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Web.Controllers
{
    [Route("Property/{propertyId:long}/Photos")]
    public class PropertyPhotoController : Controller
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IPropertyPhotoRepository _propertyPhotoRepository;
        private readonly IMapper _mapper;

        public PropertyPhotoController(IPropertyRepository propertyRepository, IPropertyPhotoRepository propertyPhotoRepository, IMapper mapper)
        {
            _propertyRepository = propertyRepository ?? throw new ArgumentNullException(nameof(propertyRepository));
            _propertyPhotoRepository = propertyPhotoRepository ?? throw new ArgumentNullException(nameof(propertyPhotoRepository));
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

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(long propertyId, IFormFile photo)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long propertyId, long id)
        {
            var propertyPhoto = await _propertyPhotoRepository.GetAsync(id);

            if (propertyPhoto == null)
            {
                return NotFound();
            }

            await _propertyPhotoRepository.DeleteAsync(propertyPhoto);

            return RedirectToAction("Index");
        }
    }
}
