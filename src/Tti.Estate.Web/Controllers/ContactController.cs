using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Services;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService ?? throw new ArgumentNullException(nameof(contactService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult Create(long? customerId, long? propertyId)
        {
            if (customerId.HasValue == propertyId.HasValue)
            {
                return BadRequest();
            }

            ContactModel model = new ContactModel()
            {
                CustomerId = customerId,
                PropertyId = propertyId
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
        public async Task<IActionResult> Create(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var contact = _mapper.Map<Contact>(model);

                await _contactService.CreateAsync(contact);
                
                if (model.PropertyId.HasValue)
                {
                    return RedirectToAction("Details", "Property", new { id = model.PropertyId.Value });
                }
                else if (model.CustomerId.HasValue)
                {
                    return RedirectToAction("Details", "Customer", new { id = model.CustomerId.Value });
                }
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

        [HttpGet]
        public async Task<IActionResult> Update(long id)
        {
            var contact = await _contactService.GetAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<ContactEditModel>(contact);

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
        public async Task<IActionResult> Update(ContactEditModel model)
        {
            if (ModelState.IsValid)
            {
                var contact = _mapper.Map<Contact>(model);

                await _contactService.UpdateAsync(contact);

                if (model.PropertyId.HasValue)
                {
                    return RedirectToAction("Details", "Property", new { id = model.PropertyId.Value });
                }
                else if (model.CustomerId.HasValue)
                {
                    return RedirectToAction("Details", "Customer", new { id = model.CustomerId.Value });
                }
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
