using Microsoft.AspNetCore.Mvc;
using night_life_sk.Dto.Event;
using night_life_sk.Dto.Place;
using night_life_sk.Dto.User;
using night_life_sk.Services;

namespace night_life_sk.Controllers
{
    [Route("api/v1/map")]
    [ApiController]
    internal class MapController : ControllerBase
    {
        private readonly BaseMapService mapService;
        public MapController(BaseMapService mapService)
        {
            this.mapService = mapService;
        }

        [HttpGet("/coordinates")]
        [ProducesResponseType(200, Type = typeof(Task<HashSet<PlaceCoordinates>>))]
        internal async Task<IActionResult> GetAllPlaces() => Ok(await mapService.GetAllPartyPlaces());

        [HttpGet("/place-on-click")]
        [ProducesResponseType(200, Type = typeof(Task<PlaceAndEventDto>))]
        internal async Task<IActionResult> GetPlaceAndEventOnClick (
            [FromQuery] double longitude,
            [FromQuery] double latitude,
            [FromQuery] DateTime date)
        {
            return Ok(await mapService.GetPlaceAndEventOnClick(longitude, latitude, date));
        }

        [HttpGet("/events/{date}")]
        [ProducesResponseType(200, Type = typeof(Task<HashSet<PartyEventDto>>))]
        internal async Task<IActionResult> GetAllEventsByDate(DateTime date)
        {
            return Ok(await mapService.GetEventsByDate(date));
        }

        [HttpGet("/events/filtered")]
        [ProducesResponseType(200, Type = typeof(Task<HashSet<PlaceCoordinates>>))]
        internal async Task<IActionResult> GetFilteredEvents([FromQuery] FilteredEventsDto filteredParam)
        {
            return Ok(await mapService.GetFilteredEvents(filteredParam));
        }

        [HttpGet("/show-interested/{eventName}")]
        [ProducesResponseType(200, Type = typeof(Task<HashSet<AppUserDto>>))]
        internal async Task<IActionResult> GetInterestedUsersForEvent(string eventName)
        {
            return Ok(await mapService.GetInterestedUsersForEvent(eventName));
        }
    }
}
