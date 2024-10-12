using Microsoft.AspNetCore.Mvc;
using Odonto.Application.ServiceAbstraction;
using Odonto.Shared.DTOs.ServicesDTO;

namespace Odonto.Presentacion.Controllers
{
    [ApiController]
    [Route("api/services")]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ServicesController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [HttpPost("RegisterService")]
        public async Task<IActionResult> RegisterService([FromBody] ServiceRequestDto serviceRequestDto)
        {
            var response = await _serviceManager.ServicesApplication.CreateService(serviceRequestDto);

            return Ok(response);
            //OR

        }
    }
}
