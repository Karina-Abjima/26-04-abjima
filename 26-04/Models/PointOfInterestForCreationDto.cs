using Microsoft.AspNetCore.Mvc;

namespace _26_04.Models
{ 
    public class PointOfInterestForCreationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public string? Description { get; set; }
    }
}
