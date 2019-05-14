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
//        private Search _search;

//        public SearchController()
//        {
//            _search = new Search();
//        }

//        /// <summary>
//        /// This searches for a character in a specific location.
//        /// </summary>
//        /// <param name="character">Ex: Waldo, Carmen, Billy Bob</param>
//        /// <param name="location">Ex: Atlanta, San Diego, Hot Springs</param>
//        /// <returns></returns>
//        [HttpGet]
//        public IActionResult Get([FromQuery, Required] string character, [FromQuery, Required] string location)
//        {
//            var response = _search.ForCharacterByLocation(character, location);
//            if (response == null) return NotFound();
//            return Ok(response);
//        }
//    }
//}
