using AutoMapper;
using geosphere_api.DTOs;
using geosphere_api.Interfaces;
using geosphere_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace geosphere_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : Controller
    {
        private readonly IPlaceRepository _placeRepository;
        private readonly IMapper _mapper;
        public PlaceController(IPlaceRepository placeRepository, IMapper mapper)
        {
            this._placeRepository = placeRepository;
            this._mapper = mapper;
        }

        //[HttpGet("{lng}/{lat}")]
        //[ProducesResponseType(200, Type = typeof(PlaceDto))]
        //public async Task<IActionResult> GetPlaceWithCoodinates(float lng, float lat)
        //{
        //    var place = _mapper.Map<PlaceDto>(await _placeRepository.GetPlaceWithCoordinates([lng, lat]));

        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    if (place is null) return NotFound();

        //    return Ok(place);
        //}

        [HttpGet("")]
        [ProducesResponseType(200, Type = typeof(PlaceDto))]
        public async Task<IActionResult> GetPlace([FromQuery] Place feature)
        {
            var place = _mapper.Map<PlaceDto>(await _placeRepository.GetPlace(feature));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (place is null) return NotFound();

            return Ok(place);
        }
    }
}
