using _26_04.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace _26_04.Controllers
{
    [Route("api/cities/{cityId}/pointofinterest")]
    [ApiController]
    public class PointOfInterestController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestForCreationDto>> GetPointsOfInterest(int cityId)
        {
            var city= CitiesDataStore.Current.Cities.FirstOrDefault(c=>c.Id==cityId);
        }
    }
}
