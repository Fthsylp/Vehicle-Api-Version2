using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleApiVersion2.Data;
using VehicleApiVersion2.Data.IRepository;
using VehicleApiVersion2.Models;

namespace VehicleApiVersion2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository repository;

        public CarController(ICarRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult getAllCars()
        {
            var cars = repository.getAllCars();
            return Ok(cars);
        }
        [HttpGet("{color}")]
        public IActionResult getCarByColor(string color)
        {
            var car = repository.getCarByColor(color);
            return Ok(car);
        }
        [HttpPost("{id}")]
        public IActionResult headlightsTurner(int id)
        {
            var car = repository.headlightsTurner(id);

            if (car == null)
            {

                return BadRequest();
            }
            return Ok(car);
        }
        [HttpDelete("{id}")]
        public IActionResult deleteCar(int id)
        {
            var car = repository.deleteCar(id);
            return Ok(car);
        }
    }
}
