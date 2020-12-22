using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servicio_Lista_Numero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListadoNumerosController : ControllerBase
    {
        // GET: api/<ListadoNumerosController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("llegaste");
        }

        // GET api/<ListadoNumerosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ListadoNumerosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ListadoNumerosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ListadoNumerosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
