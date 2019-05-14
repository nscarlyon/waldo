using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using waldo.Domain;

namespace waldo.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly Characters _characters;

        public CharactersController()
        {
            _characters = new Characters();    
        }

        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return _characters.GetCharacter();
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var person = _characters.GetCharacter(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public Character Post([FromBody] Character request)
        {
            return _characters.CreatePerson(request);
        }

        [HttpPut("{id}")]
        public Character Put(int id, [FromBody] Character request)
        {
            return _characters.UpdateCharacter(request);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _characters.DeleteCharacter(id);
        }
    }
}
