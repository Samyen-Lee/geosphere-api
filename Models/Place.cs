namespace geosphere_api.Models
{
    public class Place
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public float[] Coordinates { get; set; }
        public ICollection<Ressource> Ressources { get; set; }
    }
}
