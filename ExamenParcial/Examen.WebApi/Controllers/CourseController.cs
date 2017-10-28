using Microsoft.AspNetCore.Mvc;
using Examen.UnitOfWork;
using Examen.Models;

namespace Examen.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Course")]
    public class CourseController : Controller
    {
        private readonly IUnitOfWork _unit;
        public CourseController(IUnitOfWork unit)
        {
            _unit = unit;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_unit.Courses.GetList());
        }

        //[HttpGet]
        //[Route("{id:int}")]
        //public ActionResult GetById(int id)
        //{
        //    return Ok(_unit.Courses.GetById(id));
        //}

        //[HttpPost]
        //public IActionResult Post([FromBody] Course course)
        //{
        //    if (ModelState.IsValid)
        //        return Ok(_unit.Courses.Insert(course));
        //    return BadRequest(ModelState);
        //}
        //[HttpPut]
        //public IActionResult Put([FromBody] Course course)
        //{
        //    if (ModelState.IsValid && _unit.Courses.Update(course))
        //        return Ok(new { Message = "The course is updated" });
        //    return BadRequest(ModelState);
        //}
        //[HttpDelete]
        //public IActionResult Delete([FromBody] Course course)
        //{
        //    if (course.CourseID > 0)
        //        return Ok(_unit.Courses.Delete(course));
        //    return BadRequest(new { Message = "Incorrect data." });
        //}
    }

}
