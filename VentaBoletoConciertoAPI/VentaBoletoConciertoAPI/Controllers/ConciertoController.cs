using Microsoft.AspNetCore.Http.HttpResults;
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
        public async Task<ActionResult<IEnumerable<ConciertoDTO>>> Get()
        {
            var conciertos = await this.gestionarConciertoBW.ListarConciertos();

            if (conciertos is null) 
            {
                return NotFound(conciertos);              
            }

            return Ok(ConciertoMapper.ConciertosToDTOs((IEnumerable<Concierto>)conciertos));
        }

        // GET: api/<ConciertoController>
        [HttpGet("{idConcierto}")]
        public async Task<ActionResult<ConciertoDTO>> Get(int idConcierto)
        {
            var concierto = await this.gestionarConciertoBW.GetConcierto(idConcierto);

            if (concierto is null) 
            {
                return NotFound(concierto);
            }

            return Ok(ConciertoMapper.ConciertoToDTO(concierto));
        }
    }
}
