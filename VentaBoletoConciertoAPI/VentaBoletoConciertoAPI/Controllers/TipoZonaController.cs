using Microsoft.AspNetCore.Mvc;
using Venta.BW.Interfaces.BW;
using Venta.DA.Entidades;
using VentaBoletoConciertoAPI.Utilitarios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VentaBoletoConciertoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoZonaController : ControllerBase
    {
        private readonly IGestionarTipoZonaBW gestionarTipoZonaBW;

        public TipoZonaController(IGestionarTipoZonaBW gestionarTipoZonaBW)
        {
            this.gestionarTipoZonaBW = gestionarTipoZonaBW;
        }

        // GET: api/<TipoZonaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoZonaDTO>>> Get()
        {
            var tiposZona = await this.gestionarTipoZonaBW.ListarTiposDeZonas();

            if (tiposZona is null) 
            {
                return NotFound(tiposZona);
            }

            return Ok(TipoZonaMapper.TiposZonaToDTOs((IEnumerable<TipoZona>)tiposZona));
        }
    }
}
