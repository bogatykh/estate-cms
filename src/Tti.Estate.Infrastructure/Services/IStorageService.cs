using Microsoft.WindowsAzure.Storage.Blob;
using System;

namespace Tti.Estate.Infrastructure.Services
{
    public interface IStorageService
    {
        ICloudBlob GetBlockBlob(string containerName, string blobName);
        Uri GetContainerUri(string containerName);
    }
}
