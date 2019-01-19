using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Create()
        {
            ContactModel model = new ContactModel();

            return View(model);
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
