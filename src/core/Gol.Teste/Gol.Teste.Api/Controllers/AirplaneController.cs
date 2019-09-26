using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gol.Teste.Domain.Contratos.Servicos;
using Gol.Teste.Domain.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IEnumerable<Airplane>> Get()
        {

            var res = await _service.BuscarTodos();

            return res;
        }
    }
}