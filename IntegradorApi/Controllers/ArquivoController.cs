using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using seq.Domain.Entities.Arquivo;
using seq.Domain.Interface.Application.Arquivo;

namespace IntegradorApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArquivoController : ControllerBase
    {
        private readonly IArquivoAppService _context;
        private readonly ILogger<ArquivoController> _logger;


        public ArquivoController(IArquivoAppService context, ILogger<ArquivoController> logger)
        {
            _context = context;
            _logger = logger;

        }

        // GET: api/Arquivo
        [HttpGet("Search")]
        public async Task<IEnumerable<ArquivoModel>> Search(long id, string Descricao)
        {
            var arquivoModel = new ArquivoModel()
            {
                Id = id,
                Descricao = Descricao
            };
            var retorno = await _context.Search(arquivoModel);
            return retorno.ToArray();
        }

        // GET: api/Arquivo/5
        [HttpGet("{id}", Name = "ArquivoGet")]
        public string ArquivoGet(int id)
        {
            return "value";
        }

        // POST: api/Arquivo
        [HttpPost("Post")]
        public async Task<IActionResult> Post(ArquivoModel entity)
        {
            ArquivoModel arquivoModel = new ArquivoModel()
            {
                Descricao = entity.Descricao
            };
            var retorno = await _context.Insert(arquivoModel);
            return null;
        }

        // PUT: api/Arquivo/5
        [HttpPut("ArquivoPut")]
        public void ArquivoPut(int id, [FromBody] string descricao)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("ArquivoDelete/{id}")]
        public void ArquivoDelete(int id)
        {
        }
    }
}
