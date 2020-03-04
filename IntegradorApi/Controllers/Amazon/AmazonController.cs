using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using seq.Domain.Interface.Application.Amazon;

namespace IntegradorApi.Controllers.Amazon
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmazonController : ControllerBase
    {
        private readonly IAmazonAppService _context;

        public AmazonController(IAmazonAppService context)
        {
            _context = context;

        }

        [HttpGet("AmazonGet")]
        public IEnumerable<string> AmazonGet()
        {
            return new string[] { "Ivan", "value2" };
        }

        // GET: api/Amazon/5
        [HttpGet("{id}", Name = "AmazonGet")]
        public string AmazonGet(int id)
        {
            return "value";
        }

        // POST: api/Amazon
        [HttpPost("AmazonPost")]
        public void AmazonPost(string value)
        {
            _context.Processa(value);
        }

        // PUT: api/Amazon/5
        [HttpPut("Amazon {id}")]
        public void AmazonPut(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("AmazonDelete{id}")]
        public void AmazonDelete(int id)
        {
        }
    }
}
