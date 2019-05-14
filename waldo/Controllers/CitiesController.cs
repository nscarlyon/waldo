using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using waldo.Domain;
using waldo.Domain.ApiModels;

namespace waldo.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        private CitiesDomain _citiesDomain;

        public CitiesController(CitiesDomain citiesDomain)
        {
            _citiesDomain = citiesDomain;
        }

        [HttpGet]
        public CitiesResponse Get()
        {
            return _citiesDomain.GetCities();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(City), StatusCodes.Status200OK)]
        [ProducesResponseType(404)]
        public IActionResult Get(string id)
        {
            var city = _citiesDomain.GetCity(id);
            if (city == null) return NotFound();
            return Ok(city);
        }

        [HttpPost]
        public City Post([FromBody] City request)
        {
            return _citiesDomain.CreateCity(request);
        }

        [HttpPut("{id}")]
        public City Put(int id, [FromBody] City request)
        {
            return _citiesDomain.UpdateCity(request);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(405)]
        public IActionResult Delete(int id)
        {
            return StatusCode(405);
        }

        [HttpGet("find-waldo/{cityName}")]
        public FindWaldoResponse FindWaldo(string cityName)
        {
            return _citiesDomain.FindWaldo(cityName);
        }

        [HttpGet("{where-is-waldo}")]
        public FindWaldoResponse WhereIsWaldo()
        {
            return _citiesDomain.WhereIsWaldo();
        }
    }
}
