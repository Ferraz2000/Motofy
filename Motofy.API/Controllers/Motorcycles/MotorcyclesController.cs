using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Motofy.API.Controllers.Motorcycles
{
    [ApiController]
    [Route("api/motorcycles")]
    public class MotorcyclesController : ControllerBase
    {
        public MotorcyclesController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAllMotocylesAsync()
        {
            return Ok();
        }

        [HttpGet("{lincensePlate}")]
        public async Task<IActionResult> GetMotocyclesByLicensePlate(string licencesPlate)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMotorcycleAsync()
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMotorcycleLicensePlateAsync(Guid id)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMotorcycleAsync(Guid id)
        {
            return NoContent();
        }

        //[Authorize]
        [HttpPut("returnmotocycle")]
        public async Task<IActionResult> ReturnMotorcycleAsync(string name)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
