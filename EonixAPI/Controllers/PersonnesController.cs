using EonixAPI.Services;
using EonixEF.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personne.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        private readonly PersonneService _service;


        public PersonneController(PersonneService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAllPersonnes());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Personnes p = _service.GetPersonneById(id);
            if (p == null) return null;
            return Ok(p);
        }

        [HttpGet("ByFirstName/{firstname?}")]
        public IActionResult GetFirstName(string firstname)
        {
            return Ok(_service.GetByFirstName(firstname));
        }

        [HttpGet("ByName/{name?}")]
        public IActionResult GetName(string name)
        {
            if (name is null)
            {
                return Ok(_service.GetAllPersonnes());

            }
            return Ok(_service.GetByName(name));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Personnes personne)
        {
            _service.AddPersonne(personne);
            return NoContent();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Personnes personne)
        {
            _service.UpdatePersonne(personne);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeletePersonne(id);
            return NoContent();
        }
    }
}
