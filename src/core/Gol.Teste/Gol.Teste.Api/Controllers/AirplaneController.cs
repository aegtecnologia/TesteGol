using Gol.Teste.Domain.Contratos.Servicos;
using Gol.Teste.Domain.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gol.Teste.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private IAirplaneService _service;
        public AirplaneController(IAirplaneService srv)
        {
            _service = srv;
        }

        // GET api/values
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<Airplane>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(IEnumerable<Airplane>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(IEnumerable<Airplane>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Get()
        {
            var res = await _service.BuscarTodos();
            return Ok(res);
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] Airplane aviao)
        {
            await _service.Salvar(aviao);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _service.Excluir(id);
        }
    }
}