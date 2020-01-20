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
    public class CarController : ControllerBase
    {
        private IService<Car> carService;

        public CarController(IService<Car> _carService)
        {
            carService = _carService;
        }
      

        [HttpGet]
        public IActionResult Get()
        {
            var objects = carService.GetAll ();
            return Ok(objects);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            var id = carService.Post(car);
            return Ok(id);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Car car, [FromRoute] int id)
        {
            if (id != car.Id)
                return Conflict("Podales bledne ID");
            else
            {
                var isUpdateSuccessful = carService.Put(car, id);

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
          
                var isDeleteSuccessful = carService.Delete(id);

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
