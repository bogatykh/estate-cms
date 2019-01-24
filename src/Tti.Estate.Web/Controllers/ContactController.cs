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
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public ContactController(IContactRepository contactRepository, IMapper mapper)
        {
            _contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Create(long? customerId, long? propertyId)
        {
            ContactModel model = new ContactModel()
            {
                CustomerId = customerId,
                PropertyId = propertyId
            };

            if (customerId.HasValue == propertyId.HasValue)
            {
                return BadRequest();
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

        [HttpPost]
        public async Task<IActionResult> Create(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var contact = _mapper.Map<Contact>(model);

                await _contactRepository.CreateAsync(contact);
                
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
        public async Task<IEnumerable<ContactListItemModel>> GetData(ContactListRequestModel requestModel)
        {
            var spec = _mapper.Map<ContactFilterSpecification>(requestModel);

            var data = await _contactRepository.ListAsync(spec);

            return _mapper.Map<IEnumerable<ContactListItemModel>>(data);
        }
    }
}
