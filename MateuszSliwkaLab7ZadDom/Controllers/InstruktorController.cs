using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MateuszSliwkaLab7.Services;
using MateuszSliwkaLab7.Models;

namespace MateuszSliwkaLab7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstruktorController : ControllerBase
    {
        private IService<Instructor> instructorService;

        public InstruktorController(IService<Instructor> _instructorService)
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
            if (id != car.Id)
                return Conflict("Podales bledne ID");
            else
            {
                var isUpdateSuccessful = instructorService.Put(instructor, id);

                if (isUpdateSuccessful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }

                
            
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute]int id)
        {
          
                var isDeleteSuccessful = instructorService.Delete(id);

                if (isDeleteSuccessful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            



        }
    }
}
