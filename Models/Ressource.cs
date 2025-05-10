using geosphere_api.Enums;

namespace geosphere_api.Models
{
    public class Ressource
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public Guid PlaceId { get; set; }
        public Place? Place { get; set; }
        public RessourceType Type { get; set; }
        public string Source { get; set; }
    }
}
