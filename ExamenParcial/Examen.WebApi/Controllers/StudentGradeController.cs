using Microsoft.AspNetCore.Mvc;
using Examen.UnitOfWork;
using Examen.Models;

namespace Examen.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/StudentGrade")]
    public class StudentGradeController : Controller
    {
        private readonly IUnitOfWork _unit;
        public StudentGradeController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_unit.Students.GetList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.Students.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] StudentGrade Student)
        {
            if (ModelState.IsValid)
            {
                return Ok(_unit.Students.Insert(Student));
            }
            return BadRequest(ModelState);

        }

        [HttpPut]
        public IActionResult Put([FromBody] StudentGrade Student)
        {
            if (ModelState.IsValid && _unit.Students.Update(Student))
            {
                return Ok(new { Message = "The StudentGrade is Updated" });
            }
            return BadRequest(ModelState);

        }

        [HttpDelete]
        public IActionResult Delete([FromBody] StudentGrade Student)
        {
            if (Student.StudentID > 0)
            {
                return Ok(_unit.Students.Delete(Student));
            }
            return BadRequest(new { Message = "Incorrect data" });

        }
    }
}