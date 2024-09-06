using Microsoft.AspNetCore.Mvc;
using WebAPI__Eduardo_Vera_20240906.Models;
using WebAPI__Eduardo_Vera_20240906.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI__Eduardo_Vera_20240906.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {
        private readonly ISolicitudService _solicitudService;

        public SolicitudController(ISolicitudService solicitudService)
        {
            _solicitudService = solicitudService;
        }

        // GET: api/<SolicitudController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_solicitudService.solicitudes());
        }

        // GET api/<SolicitudController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_solicitudService.solicitudesUsuario(id));
        }

        // POST api/<SolicitudController>
        [HttpPost]
        public IActionResult Post([FromBody] SolicitudDTO value)
        {
            if(value == null)
            {
                return BadRequest("No se ha enviado una solicitud");
            }

            return Ok(_solicitudService.solicitud(value));
        }

        [HttpPut("{id}")]
        public IActionResult actualizarEstado([FromRoute] int id ,[FromBody] SolicitudPrestamo value)
        {
            if (value == null)
            {
                return BadRequest("No se ha enviado una solicitud");
            }

            return Ok(_solicitudService.cambiarEstado(id , value));
        }



    }
}
