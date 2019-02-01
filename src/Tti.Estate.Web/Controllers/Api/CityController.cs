using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers.Api
{
    [Route("api/[controller]", Name = "CityApi")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public CityController(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository ?? throw new ArgumentNullException(nameof(cityRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IEnumerable<CityListItemModel>> GetValues(long countyId)
        {
            return _mapper.Map<IEnumerable<CityListItemModel>>(await _cityRepository.ListAsync(new CityFilterSpecification(countyId)));
        }
    }
}
