using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Business.Services;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Extensions;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly IContactRepository _contactRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICountyRepository _countyRepository;
        private readonly IReadRepository<City> _cityRepository;
        private readonly IMapper _mapper;

        public PropertyController(IPropertyService propertyService,
            IContactRepository contactRepository,
            ICommentRepository commentRepository,
            IUserRepository userRepository,
            ICountyRepository countyRepository,
            IReadRepository<City> cityRepository,
            IMapper mapper)
        {
            _propertyService = propertyService ?? throw new ArgumentNullException(nameof(propertyService));
            _contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _countyRepository = countyRepository ?? throw new ArgumentNullException(nameof(countyRepository));
            _cityRepository = cityRepository ?? throw new ArgumentNullException(nameof(cityRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Index(PropertyListCriteriaModel criteria, int pageIndex = 0, int pageSize = 20)
        {
            var properties = await _propertyService.ListAsync(pageIndex: pageIndex, pageSize: pageSize,
                userId: criteria.UserId,
                propertyType: (PropertyType?)criteria.PropertyType,
                status: (PropertyStatus?)criteria.Status,
                transactionType: (TransactionType?)criteria.TransactionType,
                priceFrom: criteria.PriceFrom,
                priceTo: criteria.PriceTo,
                telephone: criteria.Telephone,
                code: criteria.Code
            );

            var model = new PropertyListModel()
            {
                Criteria = (criteria.UserId.HasValue || criteria.PropertyType.HasValue || criteria.Status.HasValue || criteria.TransactionType.HasValue || criteria.PriceFrom.HasValue || criteria.PriceTo.HasValue || !string.IsNullOrEmpty(criteria.Telephone) || criteria.Code.HasValue) ? criteria : null,
                Properties = _mapper.Map<PagedResultModel<PropertyListItemModel>>(properties),
                Users = _mapper.Map<IEnumerable<SelectListItem>>(await _userRepository.ListAsync(new UserFilterSpecification(onlyActive: true)))
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(PropertyListCriteriaModel criteria)
        {
            return RedirectToAction(nameof(Index), criteria);
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

                await _propertyService.CreateAsync(property);

                return RedirectToAction(nameof(Details), new { id = property.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(long id)
        {
            var property = await _propertyService.GetAsync(id);

            if (property == null)
            {
                return NotFound();
            }

            var model = _mapper.Map<PropertyDetailsModel>(property);

            model.Contacts = _mapper.Map<List<ContactListItemModel>>(await _contactRepository.ListAsync(new ContactFilterSpecification(propertyId: id)));
            model.Comments = _mapper.Map<List<CommentListItemModel>>(await _commentRepository.ListAsync(new CommentFilterSpecification(propertyId: id)));

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(long id)
        {
            var property = await _propertyService.GetAsync(id);

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
            var property = await _propertyService.GetAsync(model.Id);

            if (property == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _mapper.Map(model, property);

                property.Modified = DateTime.UtcNow;

                await _propertyService.UpdateAsync(property);

                return RedirectToAction(nameof(Details), new { id = property.Id });
            }

            await PrepareModelAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            var result = await _propertyService.DeleteAsync(id);

            if (result == Business.Dto.OperationResult.NotFound)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Process(long id)
        {
            var property = await _propertyService.GetAsync(id);

            if (property == null)
            {
                return NotFound();
            }

            var model = new PropertyProcessModel()
            {
                PropertyId = id
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
        public async Task<IActionResult> Process(PropertyProcessModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _propertyService.ProcessAsync(
                    id: model.PropertyId,
                    status: (PropertyStatus)model.Status,
                    comment: model.Comment
                );

                if (result == Business.Dto.OperationResult.NotFound)
                {
                    return NotFound();
                }
                else if (result == Business.Dto.OperationResult.BadRequest)
                {
                    return BadRequest();
                }

                return RedirectToAction(nameof(Details), new { id = model.PropertyId });
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
        public async Task<IActionResult> Activate(long id)
        {
            var result = await _propertyService.ActivateAsync(id);

            if (result == Business.Dto.OperationResult.NotFound)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Details), new { id });
        }

        private async Task PrepareModelAsync(PropertyModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            model.Users = _mapper.Map<IEnumerable<SelectListItem>>(await _userRepository.ListAsync(new UserFilterSpecification(onlyActive: true)));
            model.Counties = _mapper.Map<IEnumerable<SelectListItem>>(await _countyRepository.ListAsync(new CountyFilterSpecification()));

            if (model.CountyId.HasValue)
            {
                model.Cities = _mapper.Map<IEnumerable<SelectListItem>>(await _cityRepository.ListAsync(new CityFilterSpecification(model.CountyId.Value)));
            }
        }
    }
}
