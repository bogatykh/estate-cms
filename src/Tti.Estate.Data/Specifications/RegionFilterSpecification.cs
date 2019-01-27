using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Specifications
{
    public class RegionFilterSpecification : BaseSpecification<Region>
    {
        public RegionFilterSpecification(long? parentId = null)
            : base(x => !parentId.HasValue || x.Parent.Id == parentId)
        {
            ApplyOrderBy(x => x.Name);
        }
    }
}
