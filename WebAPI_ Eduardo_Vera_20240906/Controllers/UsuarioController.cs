using Microsoft.AspNetCore.Mvc;
using WebAPI__Eduardo_Vera_20240906.Models;
using WebAPI__Eduardo_Vera_20240906.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI__Eduardo_Vera_20240906.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_usuarioService.usuarios());
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_usuarioService.usuario(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] LoginDTO value)
        {
            if(value == null)
            {
                return BadRequest("No se ha enviado un usuario");
            }


            return Ok(_usuarioService.login(value));
        }


        [HttpPost("registrar")]
        public IActionResult registrarUsuario([FromBody] UsuarioDTO value)
        {
            if (value == null)
            {
                return BadRequest("No se ha enviado un usuario");
            }


            return Ok(_usuarioService.crearUsuario(value));
        }




        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
