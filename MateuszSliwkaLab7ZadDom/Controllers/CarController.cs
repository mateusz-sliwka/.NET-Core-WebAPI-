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
    public class CarController : ControllerBase //kontroler klasy samochodu
    {
        private ICarService carService;

        public CarController(ICarService _carService) //konstruktor kontrolera
        {
            carService = _carService; //przypisanie do zmiennej serwisu
        }
      

        [HttpGet]
        public IActionResult Get() //obsluga zadania get
        {
      
            return Ok(carService.GetAll()); //zwrocenie listy wszystkich samochodow
        }
        [HttpPost]
        public IActionResult Post([FromBody] Car car) //obsluga zadania post
        {
            var id = carService.Post(car); //przypisanie do zmiennej id wyniku wstawiania obiektu samochodu do bazy
            return Ok(id); //zwrocenie komunikatu razem z id wstawionego auta
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Car car, [FromRoute] int id) //obsluga zadania put, zaktualizowania obiektu, id pobierane z uri
        {
            var isUpdateSuccessful = carService.Put(car, id); //przypisanie do zmiennej wyniku aktualizacji obiektu
            if (isUpdateSuccessful) //zwrocenie dwoch komuniaktow w zalznosci od powodzenia aktualizacji
                return NoContent();
            else
                return NotFound();
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute]int id) //obsluga 
        {
                var isDeleteSuccessful = carService.Delete(id); //to samo co w PUT

                if (isDeleteSuccessful)
                    return NoContent();
                else
                    return NotFound();
        }
    }
}
