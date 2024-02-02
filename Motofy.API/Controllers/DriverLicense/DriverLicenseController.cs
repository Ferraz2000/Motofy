using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Motofy.API.Controllers.DriverLicense
{
    [ApiController]
    [Route("api/driverlicense")]
    public class DriverLicenseController : ControllerBase
    {

        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> PostLicenseAsync(string name)
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
