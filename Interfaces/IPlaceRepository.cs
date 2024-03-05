using geosphere_api.Models;

namespace geosphere_api.Interfaces
{
    public interface IPlaceRepository
    {
        Place GetPlaceWithCoordinates(float[] coordinates);
    }
}
