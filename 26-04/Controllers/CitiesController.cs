using Microsoft.AspNetCore.Mvc;

namespace _26_04.Controllers


{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        public JsonResult GetResult()
        {
            return new JsonResult(
        new List<object>
            {   new {id=1,Name ="new york city"},
                new{id=2,Name="Antwerp"}

            }
            );

        }
    }
}
