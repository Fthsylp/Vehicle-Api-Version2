using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleApiVersion2.Data;
using VehicleApiVersion2.Data.IRepository;

namespace VehicleApiVersion2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusRepository repository;

        public BusController(IBusRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("{color}")]
        public IActionResult getBusByColor([FromRoute(Name = "color")] string color)
        {
            var bus = repository.getBusByColor(color);

            if (bus == null)
            {
                return BadRequest();
            }

            return Ok(bus);
        }
    }
}
