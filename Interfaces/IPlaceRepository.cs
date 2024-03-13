using geosphere_api.Models;

namespace geosphere_api.Interfaces
{
    public interface IPlaceRepository
    {
        //Task<Place> GetPlaceWithCoordinates(float[] coordinates);

        Task<Place> GetPlace(Place feature);
    }
}
