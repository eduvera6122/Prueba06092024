using Microsoft.AspNetCore.Mvc;
using WebAPI__Eduardo_Vera_20240906.Models;
using WebAPI__Eduardo_Vera_20240906.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI__Eduardo_Vera_20240906.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        private readonly IPrestamoService _service;

        public PrestamoController(IPrestamoService service)
        {
            _service = service;
        }
            

        // GET: api/<PrestamoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.prestamos());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.prestamoUsuario(id));
        }

        // POST api/<PrestamoController>
        [HttpPost]
        public IActionResult Post([FromBody] PrestamoDTO value)
        {
            if(value == null)
            {
                return BadRequest("No se ha enviado una solicitud");
            }


            return Ok(_service.prestamo(value));
        }

        // PUT api/<PrestamoController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Prestamo value)
        {
            if(value == null)
            {
                return BadRequest("No se ha enviado una solicitud");
            }

            return Ok(_service.cambiarEstado(id, value));
        }


    }
}
