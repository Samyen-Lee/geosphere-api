using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using geosphere_api.Interfaces;

namespace geosphere_api.Helpers
{
    public class MediaManager : IMediaService
    {
        private readonly Cloudinary _cloudinary;
        public MediaManager()
        {
            _cloudinary = new Cloudinary(Environment.GetEnvironmentVariable("CLOUDINARY_URL"));
            _cloudinary.Api.Secure = true;
        }
        public async Task<ImageUploadResult> AddImage(string filepath)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(@"C:\Users\Sam25\Pictures\my_image.jpeg"),
            };
            
            return await _cloudinary.UploadAsync(uploadParams);
        }

        public async Task<VideoUploadResult> AddVideo(string filepath)
        {
            var uploadParams = new VideoUploadParams()
            {
                File = new FileDescription(@"C:\Users\Sam25\Pictures\my_image.jpeg"),
            };

            return await _cloudinary.UploadAsync(uploadParams);
        }
    }
}
