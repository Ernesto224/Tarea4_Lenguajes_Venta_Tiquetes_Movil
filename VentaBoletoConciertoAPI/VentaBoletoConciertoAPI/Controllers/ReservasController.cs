using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Venta.BW.Interfaces.BW;
using Venta.DA.Entidades;
using VentaBoletoConciertoAPI.Utilitarios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VentaBoletoConciertoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly IGestionarReservaBW gestionarReservaBW;

        public ReservasController(IGestionarReservaBW gestionarReservaBW)
        {
            this.gestionarReservaBW = gestionarReservaBW;
        }

        // GET: api/<ReservasController>
        [HttpGet("{idUsuario}")]
        public async Task<ActionResult<IEnumerable<ReservaDTO>>> Get(int idUsuario)
        {
            var reservas = await this.gestionarReservaBW.GetReservasPorUsuario(idUsuario);
            
            if (reservas == null)
            {
                return NotFound(reservas);
            }

            return Ok(ReservaMapper.MapToReservaDTO((List<Reserva>)reservas));
        }

        // POST api/<ReservasController>
        [HttpPost]
        public async Task<ActionResult<bool>> Post(int idUsuario, int idAsiento, DateTime fechaCompra)
        {
            var resultado = await this.gestionarReservaBW.RealizarNuevaReserva(idUsuario, idAsiento, fechaCompra);

            if(resultado)
            {
                return NotFound(resultado);
            }

            return Ok(resultado);
        }

    }
}
