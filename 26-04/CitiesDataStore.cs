
using _26_04.Models;
namespace _26_04
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore() 
        { //dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "the central park is amazin"
                },
                new CityDto()
                {Id = 2,
                 Name="Delhi",
                 Description="It is a whole vibe to be here"

                }, 
                new CityDto()
                {Id=3,
                Name="Shanghai",
                Description="the food is to die for"
                }

            };
        }
    }
}
