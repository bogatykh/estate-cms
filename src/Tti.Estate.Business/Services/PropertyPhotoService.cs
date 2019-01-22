using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Services;

namespace Tti.Estate.Business.Services
{
    internal class PropertyPhotoService : IPropertyPhotoService
    {
        private readonly IStorageService _storageService;
        private readonly IImageService _imageService;
        private readonly IPropertyPhotoRepository _propertyPhotoRepository;

        private const string PhotosContainerName = "photos";

        public PropertyPhotoService(IStorageService storageService, IImageService imageService, IPropertyPhotoRepository propertyPhotoRepository)
        {
            _storageService = storageService;
            _imageService = imageService;
            _propertyPhotoRepository = propertyPhotoRepository;
        }

        public async Task CreateAsync(long propertyId, Stream stream)
        {
            var externalId = Guid.NewGuid();
            var blobName = $"{externalId}.jpg";

            var blockBlob = _storageService.GetBlockBlob(PhotosContainerName, blobName);
            blockBlob.Metadata.Add("propertyId", propertyId.ToString());

            await blockBlob.UploadFromStreamAsync(stream);

            await _propertyPhotoRepository.CreateAsync(new PropertyPhoto()
            {
                PropertyId = propertyId,
                ExternalId = externalId
            });
        }

        public async Task<IEnumerable<PropertyPhoto>> ListAsync(long propertyId)
        {
            var spec = new PropertyPhotoSpecification(propertyId);

            return await _propertyPhotoRepository.ListAsync(spec);
        }

        public Uri GetStorageUri()
        {
            return _storageService.GetContainerUri(PhotosContainerName);
        }
    }
}
