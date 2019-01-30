using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class CountyFilterSpecification : BaseSpecification<County>
    {
        public CountyFilterSpecification()
        {
            ApplyOrderBy(x => x.Name);
        }
    }
}
