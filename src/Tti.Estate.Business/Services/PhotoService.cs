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
    internal class PhotoService : IPhotoService
    {
        private readonly IImageService _imageService;
        private readonly IPhotoRepository _photoRepository;
        private readonly IPhotoBlobRepository _photoBlobRepository;

        private const int PhotoResizePixels = 1024;
        private const int PhotoResizeQuality = 90;

        public PhotoService(IPhotoRepository photoRepository, IPhotoBlobRepository photoBlobRepository, IImageService imageService)
        {
            _photoRepository = photoRepository;
            _photoBlobRepository = photoBlobRepository;
            _imageService = imageService;
        }

        public async Task CreateAsync(long propertyId, Stream stream)
        {
            var photo = new Photo()
            {
                PropertyId = propertyId
            };

            using (var outputStream = await _photoBlobRepository.OpenWriteAsync(GetBlobName(photo)))
            {
                _imageService.Resize(stream, outputStream, PhotoResizePixels, PhotoResizeQuality);
            }

            await _photoRepository.CreateAsync(photo);
        }

        public async Task<IEnumerable<Photo>> ListAsync(long propertyId)
        {
            var spec = new PhotoFilterSpecification(propertyId);

            return await _photoRepository.ListAsync(spec);
        }

        public Uri GetStorageUri()
        {
            return _photoBlobRepository.GetContainerUri();
        }

        public async Task DeleteAsync(long id)
        {
            var photo = await _photoRepository.GetAsync(id);

            await _photoRepository.DeleteAsync(photo);

            await _photoBlobRepository.DeleteAsync(GetBlobName(photo));
        }

        private string GetBlobName(Photo photo)
        {
            return $"{photo.ExternalId}.jpg";
        }
    }
}
