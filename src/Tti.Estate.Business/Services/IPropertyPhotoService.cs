using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Services
{
    public interface IPropertyPhotoService
    {
        Task CreateAsync(long propertyId, Stream stream);
        Task<IEnumerable<PropertyPhoto>> ListAsync(long propertyId);
        Uri GetStorageUri();
        Task DeleteAsync(long id);
    }
}
