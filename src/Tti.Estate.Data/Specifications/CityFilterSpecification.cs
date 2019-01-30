using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class CityFilterSpecification : BaseSpecification<City>
    {
        public CityFilterSpecification(long countyId)
            : base(x => x.CountyId == countyId)
        {
            ApplyOrderBy(x => x.Name);
        }
    }
}
