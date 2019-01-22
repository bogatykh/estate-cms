using SkiaSharp;
using System;
using System.IO;

namespace Tti.Estate.Infrastructure.Services
{
    internal class ImageService : IImageService
    {
        public ImageService()
        {

        }

        public void Resize(Stream inputStream, Stream outputStream, int size, int quality)
        {
            if (inputStream == null)
            {
                throw new ArgumentNullException(nameof(inputStream));
            }
            if (outputStream == null)
            {
                throw new ArgumentNullException(nameof(outputStream));
            }

            using (var managedStream = new SKManagedStream(inputStream))
            {
                using (var original = SKBitmap.Decode(managedStream))
                {
                    int width, height;
                    if (original.Width > original.Height)
                    {
                        width = size;
                        height = original.Height * size / original.Width;
                    }
                    else
                    {
                        width = original.Width * size / original.Height;
                        height = size;
                    }

                    using (var resized = original.
                           Resize(new SKImageInfo(width, height), SKFilterQuality.Medium))
                    {
                        if (resized == null) return;

                        using (var image = SKImage.FromBitmap(resized))
                        {
                            image.
                                Encode(SKEncodedImageFormat.Jpeg, quality).
                                SaveTo(outputStream);
                        }
                    }
                }
            }
        }
    }
}
