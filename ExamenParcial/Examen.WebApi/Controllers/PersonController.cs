using Microsoft.AspNetCore.Mvc;
using Examen.UnitOfWork;
using Examen.Models;

namespace Examen.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        private readonly IUnitOfWork _unit;
        public PersonController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_unit.Persons.GetList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Persons.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (ModelState.IsValid)
            {
                return Ok(_unit.Persons.Insert(person));
            }
            return BadRequest(ModelState);

        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (ModelState.IsValid && _unit.Persons.Update(person))
            {
                return Ok(new { Message = "The Person is Updated" });
            }
            return BadRequest(ModelState);

        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Person person)
        {
            if (person.PersonID > 0)
            {
                return Ok(_unit.Persons.Delete(person));
            }
            return BadRequest(new { Message = "Incorrect data" });

        }
    }
}