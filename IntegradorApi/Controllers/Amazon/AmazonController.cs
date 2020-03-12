using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using seq.Application.Interfaces;
using seq.Infra.CrossCutting.Email;

namespace IntegradorApi.Controllers.Amazon
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmazonController : ControllerBase
    {
        private readonly IAmazonAppService _context;
        private readonly IEmailSender _emailSender;
        private readonly ILogger<AmazonController> _logger;
        public AmazonController(IAmazonAppService context, IEmailSender emailSender, ILogger<AmazonController> logger)
        {
            _context = context;
            _emailSender = emailSender;
            _logger = logger;
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
        public async Task<IActionResult> AmazonPost(string value)
        {
            return Ok(_context.ProcessaXML(value));
        }

        [HttpPost("AmazonEmail")]
        public async Task<IActionResult> AmazonEmail()
        {
            try
            {
                var Destino = "oajrantunes@gmail.com";
                var Assunto = "Teste email Sequoia";
                var Mensagem = "Aeee Funcionou";

                //try
                //{
                //    throw new Exception("This is one badass exception. :)");
                //}
                //catch (Exception ex)
                //{
                //    _logger.LogError("It seems the exception happened. :(");
                //    _logger.LogWarning("This is your last warning!");
                //    _logger.LogInformation("And this is fatal error...");
                //}
                               
                await TesteEnvioEmail(Destino, Assunto, Mensagem);

                return Ok(1);
            }
            catch (Exception)
            {
                return Ok(0);
            }
        }

        public async Task TesteEnvioEmail(string email, string assunto, string mensagem)
        {
            try
            {
                //email destino, assunto do email, mensagem a enviar
                await _emailSender.SendEmailAsync(email, assunto, mensagem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
