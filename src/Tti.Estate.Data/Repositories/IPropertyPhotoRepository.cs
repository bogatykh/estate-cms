﻿using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public interface IPropertyPhotoRepository : IRepository<PropertyPhoto>, IReadRepository<PropertyPhoto>, IWriteRepository<PropertyPhoto>
    {
    }
}