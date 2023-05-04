namespace _26_04.Models
{
 
    /// A DTO for a city without points of interest

    public class CityWithoutPointsOfInterestDto
    {
        /// The id of the city
    
        public int Id { get; set; }

     
        /// The name of the city
   
        public string Name { get; set; } = string.Empty;

    
        /// The description of the city
     
        public string? Description { get; set; }
    }
}
