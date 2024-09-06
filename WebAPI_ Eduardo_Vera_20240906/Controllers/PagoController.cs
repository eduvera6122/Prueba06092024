using Microsoft.AspNetCore.Mvc;
using WebAPI__Eduardo_Vera_20240906.Models;
using WebAPI__Eduardo_Vera_20240906.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI__Eduardo_Vera_20240906.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly IPagoService _pagoService;

        public PagoController(IPagoService pagoService)
        {
            _pagoService = pagoService;
        }


        // GET: api/<PagoController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pagoService.pagos());
        }

        // GET api/<PagoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_pagoService.pagosUsuario(id));
        }

        // POST api/<PagoController>
        [HttpPost]
        public IActionResult Post([FromBody] PagoDTO value)
        {
            if(value == null)
            {
                return BadRequest();
            }


            return Ok(_pagoService.pago(value));
        }

    }
}
