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

        public async Task<Place> GetPlace(Place feature)
        {
            return await _context.Places.Include(p => p.Ressources).Where(p => p.Name == feature.Name && p.Subdivision == feature.Subdivision && p.Country == feature.Country && p.Category == feature.Category).FirstOrDefaultAsync();
        }

        //public async Task<Place> GetPlaceWithCoordinates(float[] coordinates)
        //{
        //    return await _context.Places.Include(p => p.Ressources).Where(p => p.Coordinates == coordinates).FirstOrDefaultAsync();
        //}
    }
}
