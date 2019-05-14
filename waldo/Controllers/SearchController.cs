//using System.ComponentModel.DataAnnotations;
//using Microsoft.AspNetCore.Mvc;
//using waldo.Domain;

//namespace waldo.Web.Controllers
//{
//    [Route("api/v{version:apiVersion}/[controller]")]
//    [ApiVersion("2.0")]
//    [ApiController]
//    public class SearchController : ControllerBase
//    {
//        private SearchDomain _searchDomain;

//        public SearchController(SearchDomain searchDomain)
//        {
//            _searchDomain = searchDomain;
//        }

//        /// <summary>
//        /// This searches for a character in a specific location.
//        /// </summary>
//        /// <param Name="character">Ex: Waldo, Carmen, Billy Bob</param>
//        /// <param Name="location">Ex: Atlanta, San Diego, Hot Springs</param>
//        /// <returns></returns>
//        [HttpGet]
//        public IActionResult Get([FromQuery, Required] string character, [FromQuery, Required] string location)
//        {
//            var response = _searchDomain.ForCharacterByLocation(character, location);
//            if (response == null) return NotFound();
//            return Ok(response);
//        }
//    }
//}
