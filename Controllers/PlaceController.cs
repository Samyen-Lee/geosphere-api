using AutoMapper;
using CloudinaryDotNet.Actions;
using geosphere_api.DTOs;
using geosphere_api.Interfaces;
using geosphere_api.Interfaces.Repositories;
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
        private readonly IMediaService _mediaService;

        public PlaceController(IPlaceRepository placeRepository, IMapper mapper, IMediaService mediaService)
        {
            this._placeRepository = placeRepository;
            this._mapper = mapper;
            this._mediaService = mediaService;
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

        [HttpPost("/add-image")]
        [ProducesResponseType(200, Type = typeof(ImageUploadResult))]
        public async Task<IActionResult> AddImage()
        {
            try
            {
                var result = await _mediaService.AddImage("");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                return Ok(result);
            } catch(FileNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
