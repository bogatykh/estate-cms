using Microsoft.WindowsAzure.Storage;

namespace Tti.Estate.Infrastructure.Repositories
{
    internal class PhotoBlobRepository : BaseBlobRepository, IPhotoBlobRepository
    {
        private const string ContainerName = "photos";

        public PhotoBlobRepository(CloudStorageAccount storageAccount)
            : base(storageAccount, ContainerName)
        {
        }
    }
}
