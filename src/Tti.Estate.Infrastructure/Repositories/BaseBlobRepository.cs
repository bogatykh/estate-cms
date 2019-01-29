using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Tti.Estate.Infrastructure.Repositories
{
    public abstract class BaseBlobRepository : IBlobRepository
    {
        private readonly CloudBlobClient _blobClient;
        private readonly string _containerName;

        public BaseBlobRepository(CloudStorageAccount storageAccount, string containerName)
        {
            _blobClient = storageAccount.CreateCloudBlobClient();
            _containerName = containerName;
        }

        public Uri GetContainerUri()
        {
            var container = _blobClient.GetContainerReference(_containerName);

            return container.Uri;
        }

        public async Task<Stream> OpenWriteAsync(string blobName)
        {
            var blockBlob = GetBlockBlobReference(blobName);

            return await blockBlob.OpenWriteAsync();
        }

        public async Task DeleteAsync(string blobName)
        {
            var blockBlob = GetBlockBlobReference(blobName);

            await blockBlob.DeleteAsync();
        }

        private CloudBlockBlob GetBlockBlobReference(string blobName)
        {
            var container = _blobClient.GetContainerReference(_containerName);

            return container.GetBlockBlobReference(blobName);
        }
    }
}
