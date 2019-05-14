using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using waldo.Domain;
using waldo.Domain.ApiModels;

namespace waldo.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly CharactersDomain _charactersDomain;

        public CharactersController(CharactersDomain charactersDomain)
        {
            _charactersDomain = charactersDomain;    
        }

        [HttpGet]
        public IEnumerable<Character> Get()
        {
            return _charactersDomain.GetCharacter();
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(string id)
        {
            var person = _charactersDomain.GetCharacter(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public Character Post([FromBody] Character request)
        {
            return _charactersDomain.CreatePerson(request);
        }

        [HttpPut("{id}")]
        public Character Put(int id, [FromBody] Character request)
        {
            return _charactersDomain.UpdateCharacter(request);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _charactersDomain.DeleteCharacter(id);
        }
    }
}
