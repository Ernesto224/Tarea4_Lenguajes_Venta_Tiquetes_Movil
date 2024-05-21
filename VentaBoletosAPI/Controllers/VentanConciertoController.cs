using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Venta.BW.Interfaces.BW;

namespace VentaBoletosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentanConciertoController : ControllerBase
    {
        private readonly IGestionarVentaBW gestionarVentaBW;
        public VentanConciertoController(IGestionarVentaBW _gestionarVentaBW)
        {
            this.gestionarVentaBW = _gestionarVentaBW;  
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
