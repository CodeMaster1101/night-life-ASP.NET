using Microsoft.AspNetCore.Mvc;
using night_life_sk.Dto.Place;
using night_life_sk.Services;

namespace night_life_sk.Controllers
{
    [Route("api/v1/map")]
    [ApiController]
    public class MapController : Controller
    {
        private readonly BaseMapService mapService;
        public MapController(BaseMapService mapService)
        {
            this.mapService = mapService;
        }
        [HttpGet("coordinates")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<PlaceCoordinates>))]
        public IActionResult GetAllPlaces() => Ok(mapService.GetAllPartyPlaces());

        [HttpGet("place-on-click")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<PlaceCoordinates>))]
        public IActionResult GetPlaceAndEventOnClick (
            [FromQuery] double longitude,
            [FromQuery] double latitude,
            [FromQuery] DateTime date)
        {
            return mapService.GetPlaceAndEventOnClick(longitude, latitude, date);
        }
            
    }
}
