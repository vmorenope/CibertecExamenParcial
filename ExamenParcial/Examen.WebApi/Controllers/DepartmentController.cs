using Microsoft.AspNetCore.Mvc;
using Examen.UnitOfWork;
using Examen.Models;

namespace Examen.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Department")]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unit;
        public DepartmentController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_unit.Departments.GetList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Departments.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Department depart)
        {
            if (ModelState.IsValid)
            {
                return Ok(_unit.Departments.Insert(depart));
            }
            return BadRequest(ModelState);

        }

        [HttpPut]
        public IActionResult Put([FromBody] Department depart)
        {
            if (ModelState.IsValid && _unit.Departments.Update(depart))
            {
                return Ok(new { Message = "The Department is Updated" });
            }
            return BadRequest(ModelState);

        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Department depart)
        {
            if (depart.DepartmentID > 0)
            {
                return Ok(_unit.Departments.Delete(depart));
            }
            return BadRequest(new { Message = "Incorrect data" });

        }
    }
}