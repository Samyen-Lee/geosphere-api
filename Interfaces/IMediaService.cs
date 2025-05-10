using CloudinaryDotNet.Actions;
using CloudinaryDotNet;

namespace geosphere_api.Interfaces
{
    public interface IMediaService
    {
        public Task<ImageUploadResult> AddImage(string filepath);
        public Task<VideoUploadResult> AddVideo(string filepath);
    }
}
