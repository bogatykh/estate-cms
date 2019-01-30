using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Services
{
    public interface IPhotoService
    {
        Task CreateAsync(long propertyId, Stream stream);
        Task<IEnumerable<Photo>> ListAsync(long propertyId);
        Uri GetStorageUri();
        Task DeleteAsync(long id);
    }
}
