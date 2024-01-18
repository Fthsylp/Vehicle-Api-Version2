using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VehicleApiVersion2.Data;
using VehicleApiVersion2.Data.IRepository;

namespace VehicleApiVersion2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        private readonly IBoatRepository repository;

        public BoatController(IBoatRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet("{color}")]
        public IActionResult getBoatByColor([FromRoute(Name = "color")] string color)
        {
            var boat = repository.getBoatByColor(color);

            if (boat == null)
            {
                return BadRequest();
            }

            return Ok(boat);
        }
    }
}
