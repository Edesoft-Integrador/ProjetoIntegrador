using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using seq.Application.Interfaces;
using seq.Domain.Entities;

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
        public async Task<IActionResult> Search(long? id, string Descricao)
        {
            return Ok(await _context.Search(id, Descricao));
        }

        [HttpGet("SearchTeste")]
        public async Task<IActionResult> SearchTeste(long? id, string Descricao)
        {
            return Ok(await _context.SearchTeste(id, Descricao));
        }


        [HttpGet("SearchTesteADO")]
        public async Task<IActionResult> SearchTesteADO(long? id, string Descricao)
        {
            return Ok(await _context.SearchTesteADO(id, Descricao));
        }

        // GET: api/Arquivo/5
        [HttpGet("{id}")]
        public string ArquivoGet(int id)
        {
            return "value";
        }

        // POST: api/Arquivo
        [HttpPost]
        public async Task<IActionResult> Post(ArquivoModel entity)
        {
           return Ok(await _context.AddAsync(entity));
        }

        // PUT: api/Arquivo/5
        [HttpPut]
        public void ArquivoPut(int id, [FromBody] string descricao)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void ArquivoDelete(int id)
        {
        }
    }
}
