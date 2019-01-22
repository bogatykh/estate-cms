using System.IO;

namespace Tti.Estate.Infrastructure.Services
{
    public interface IImageService
    {
        void Resize(Stream inputStream, Stream outputStream, int size, int quality);
    }
}
