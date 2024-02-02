using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Motofy.API.Controllers.Orders
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController :ControllerBase
    {

        [AllowAnonymous]
        [HttpPost("acceptorder")]
        public async Task<IActionResult> AcceptOrderAsync(string name)
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

        [AllowAnonymous]
        [HttpPost("deliveryorder")]
        public async Task<IActionResult> DeliveryOrderAsync(string name)
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

        [AllowAnonymous]
        [HttpPost("confirmdeliveryorder")]
        public async Task<IActionResult> ConfirmDeliveryOrderAsync(string name)
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
