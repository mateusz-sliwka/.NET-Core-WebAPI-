using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MateuszSliwkaLab7ZadDom.Models;
using MateuszSliwkaLab7ZadDom.Services;
using Microsoft.AspNetCore.Mvc;


namespace MateuszSliwkaLab7ZadDom.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class InstructorController : ControllerBase //klasa dzialajca identycznie jak CarController, rozni sie tylko typem modelu/serwisu (Instructor)
    {
        private IInstructorService instructorService;

        public InstructorController(IInstructorService _instructorService)
        {
            instructorService = _instructorService;
        }
      

        [HttpGet]
        public IActionResult Get()
        {
            var objects = instructorService.GetAll ();
            return Ok(objects);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Instructor instructor)
        {
            var id = instructorService.Post(instructor);
            return Ok(id);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Instructor instructor, [FromRoute] int id)
        {
                var isUpdateSuccessful = instructorService.Put(instructor, id);
                if (isUpdateSuccessful)
                    return NoContent();
                else
                    return NotFound();
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute]int id)
        {
                var isDeleteSuccessful = instructorService.Delete(id);
                if (isDeleteSuccessful)
                    return NoContent();
                else
                    return NotFound();
        }
    }
}
