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
        public async Task<IEnumerable<ArquivoModel>> Search(long id, string Descricao)
        {
            return new List<ArquivoModel>(); // await _context.GetByIDAsync((int)id);
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
            //ArquivoModel arquivoModel = new ArquivoModel()
            //{
            //    Descricao = entity.Descricao
            //};

           return Ok(await _context.AddAsync(entity));
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
