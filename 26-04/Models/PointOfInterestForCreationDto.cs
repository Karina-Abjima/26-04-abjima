using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace _26_04.Models
{ 
    public class PointOfInterestForCreationDto
    {
        [Required]
        [MaxLength(50)]

        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
