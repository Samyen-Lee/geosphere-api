using geosphere_api.Data;
using geosphere_api.Interfaces;
using geosphere_api.Models;
using Microsoft.EntityFrameworkCore;

namespace geosphere_api.Repositories
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly DataContext _context;
        public PlaceRepository(DataContext dataContext)
        {
            this._context = dataContext;
        }
        public Place GetPlaceWithCoordinates(float[] coordinates)
        {
            return _context.Places.Include(p => p.Ressources).Where(p => p.Coordinates == coordinates).FirstOrDefault();
        }
    }
}
