﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Repositories;
using Tti.Estate.Infrastructure.Services;

namespace Tti.Estate.Business.Services
{
    internal class PropertyPhotoService : IPropertyPhotoService
    {
        private readonly IImageService _imageService;
        private readonly IPropertyPhotoRepository _propertyPhotoRepository;
        private readonly IPhotoBlobRepository _photoBlobRepository;

        private const int PhotoResizePixels = 1024;
        private const int PhotoResizeQuality = 90;

        public PropertyPhotoService(IPropertyPhotoRepository propertyPhotoRepository, IPhotoBlobRepository photoBlobRepository, IImageService imageService)
        {
            _propertyPhotoRepository = propertyPhotoRepository;
            _photoBlobRepository = photoBlobRepository;
            _imageService = imageService;
        }

        public async Task CreateAsync(long propertyId, Stream stream)
        {
            var photo = new PropertyPhoto()
            {
                PropertyId = propertyId
            };

            using (var outputStream = await _photoBlobRepository.OpenWriteAsync(GetBlobName(photo)))
            {
                _imageService.Resize(stream, outputStream, PhotoResizePixels, PhotoResizeQuality);
            }

            await _propertyPhotoRepository.CreateAsync(photo);
        }

        public async Task<IEnumerable<PropertyPhoto>> ListAsync(long propertyId)
        {
            var spec = new PropertyPhotoSpecification(propertyId);

            return await _propertyPhotoRepository.ListAsync(spec);
        }

        public Uri GetStorageUri()
        {
            return _photoBlobRepository.GetContainerUri();
        }

        public async Task DeleteAsync(long id)
        {
            var photo = await _propertyPhotoRepository.GetAsync(id);

            await _propertyPhotoRepository.DeleteAsync(photo);

            await _photoBlobRepository.DeleteAsync(GetBlobName(photo));
        }

        private string GetBlobName(PropertyPhoto photo)
        {
            return $"{photo.ExternalId}.jpg";
        }
    }
}
