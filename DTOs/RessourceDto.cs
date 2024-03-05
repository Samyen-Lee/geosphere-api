using geosphere_api.Enums;

namespace geosphere_api.DTOs
{
    public class RessourceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Guid PlaceId { get; set; }
        public RessourceType Type { get; set; }
        public string Source { get; set; }
    }
}
