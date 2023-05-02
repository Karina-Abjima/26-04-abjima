using _26_04.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace _26_04.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/cities/{cityId}/pointofinterest")]
    [ApiController]
    public class PointOfInterestController:ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestForCreationDto>> GetPointsOfInterest(int cityId)
        {
            var city= CitiesDataStore.Current.Cities.FirstOrDefault(c=>c.Id==cityId);
            if(city == null) { return NotFound(); }
            return Ok(city);

            //finding point of interesr
            var pointOfInterest = city.PointsOfInterest.FirstOrDefault(c => c.Id == pointOfInterestId);
            if(pointOfInterest == null)
            {
                return NotFound();
            }
            return Ok(pointOfInterest);
            if(pointOfInterestId==Null)//recheck
            {
                return BadRequest();
            }
            return OkObjectResult;
        }
        [HttpPost]
        public ActionResult<PointOfInterestForCreationDto>CreatePOintOfOnterest(
            int cityId,
            PointOfInterestForCreationDto pointOfInterest)
        {

        }
        [HttpPut]
        public ActionResult UpdatePointOfInterest(int cityId, int pointOfInterestId,
            PointOfInterestForForUpdateDto pointOfInterest)
    }
}
