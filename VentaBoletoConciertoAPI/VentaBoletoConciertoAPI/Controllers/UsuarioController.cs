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
    public class UsuarioController : ControllerBase
    {
        private readonly IGestionarUsuarioBW gestionarUsuarioBW;

        public UsuarioController(IGestionarUsuarioBW gestionarUsuarioBW) 
        { 
            this.gestionarUsuarioBW = gestionarUsuarioBW;
        } 

        // GET api/<UsuarioController>/5
        [HttpGet]
        public async Task<ActionResult<UsuarioDTO>> Get(string correoElectronico, string contrasenia)
        {
            var resultado = await this.gestionarUsuarioBW.InicioDeSesion(correoElectronico, contrasenia);

            if (resultado == null)
            {
                return BadRequest();
            }

            return Ok(UsuarioMapper.UserToDTO(resultado));
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<ActionResult<bool>> Post(Usuario usuario)
        {
            var resultado = await this.gestionarUsuarioBW.RegistroDeUsuario(usuario);

            if (!resultado)
            {
                return NotFound(resultado);
            }

            return Ok(resultado);
        }

    }
}
