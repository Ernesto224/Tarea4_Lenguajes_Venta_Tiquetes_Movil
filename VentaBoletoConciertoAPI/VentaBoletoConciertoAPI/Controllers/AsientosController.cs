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
    public class AsientosController : ControllerBase
    {
        private readonly IGestionarAsientosBW gestionarAsientosBW;

        public AsientosController(IGestionarAsientosBW gestionarAsientosBW) 
        {
            this.gestionarAsientosBW = gestionarAsientosBW;
        }

        // GET: api/<AsientosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AsientoDTO>>> Get(int idConcierto, int idTipoZona)
        {
            var asientos = await this.gestionarAsientosBW.AsientosDisponiblesPorConciertoYZona(idConcierto, idTipoZona);

            if (asientos is null)
            {
                return NotFound(asientos);
            }

            return Ok(AsientoMapper.AsientosToDTOs((IEnumerable<Asiento>)asientos));
        }

        // GET: api/<AsientosController>
        [HttpPut]
        public async Task<ActionResult<bool>> ActualizarReserva(int idAsiento)
        {
            var asientos = await this.gestionarAsientosBW.CambiarEstadoAsiento(idAsiento);

            if (!asientos)
            {
                return NotFound(asientos);
            }

            return Ok(asientos);
        }
    }
}
