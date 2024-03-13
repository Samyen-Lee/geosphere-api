using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace geosphere_api.Models
{
    public class Place
    {
        [BindNever]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Maki { get; set; }
        public string? Category { get; set; }
        public string Country { get; set; }
        public string Subdivision { get; set; }

        [BindNever]
        public ICollection<Ressource>? Ressources { get; set; }
    }
}
