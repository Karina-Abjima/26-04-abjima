using _26_04.Models;
using Microsoft.AspNetCore.Mvc;

namespace _26_04.Controllers


{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetResult()
        {
            return Ok(CitiesDataStore.Current.Cities);

        }
        [HttpGet("{Id}")]

        public ActionResult<CityDto> GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound();
            }
            return Ok(cityToReturn);
            //return new JsonResult( CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id)); }
        }

    }
}
