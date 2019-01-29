using System;
using System.IO;
using System.Threading.Tasks;

namespace Tti.Estate.Infrastructure.Repositories
{
    public interface IBlobRepository
    {
        Task<Stream> OpenWriteAsync(string blobName);
        Uri GetContainerUri();
        Task DeleteAsync(string blobName);
    }
}
