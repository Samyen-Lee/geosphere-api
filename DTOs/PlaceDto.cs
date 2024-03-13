using geosphere_api.Models;

namespace geosphere_api.DTOs
{
    public class PlaceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Ressource>? Ressources { get; set; }
    }
}
