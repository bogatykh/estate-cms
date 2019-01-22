using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;

namespace Tti.Estate.Infrastructure.Services
{
    internal class StorageService : IStorageService
    {
        private readonly CloudBlobClient _blobClient;

        public StorageService(CloudStorageAccount storageAccount)
        {
            _blobClient = storageAccount.CreateCloudBlobClient();
        }

        public ICloudBlob GetBlockBlob(string containerName, string blobName)
        {
            var container = _blobClient.GetContainerReference(containerName);

            return container.GetBlockBlobReference(blobName);
        }

        public Uri GetContainerUri(string containerName)
        {
            var container = _blobClient.GetContainerReference(containerName);

            return container.Uri;
        }
    }
}
