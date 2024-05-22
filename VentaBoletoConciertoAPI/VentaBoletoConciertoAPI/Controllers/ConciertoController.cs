using Microsoft.AspNetCore.Mvc;
using Venta.BC.Modelos;
using Venta.BW.Interfaces.BW;
using VentaBoletoConciertoAPI.Utilitarios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VentaBoletoConciertoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConciertoController : ControllerBase
    {
        private readonly IGestionarConciertoBW gestionarConciertoBW;

        public ConciertoController(IGestionarConciertoBW gestionarConciertoBW)
        {
            this.gestionarConciertoBW = gestionarConciertoBW;
        }

        // GET: api/<ConciertoController>
        [HttpGet]
        public async Task<IEnumerable<ConciertoDTO>> Get()
        {
            return ConciertoMapper.ConciertosToDTOs((IEnumerable<Concierto>)await this.gestionarConciertoBW.ListarConciertos());
        }
    }
}
