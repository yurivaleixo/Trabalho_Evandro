using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MacarraoController : ControllerBase
    {
        private static List<Macarrao> macarraoList = new();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(macarraoList);
        }

        [HttpGet]
        [Route("buscar/{molho}")]
        public IActionResult Buscar([FromRoute] string molho)
        {
            if (molho == null)
            {
                return BadRequest("O molho do macarrão não pode ser nulo.");
            }

            Macarrao? macarrao = macarraoList.Find(m => m.Molho == molho);

            if (macarrao != null)
            {
                return Ok(macarrao);
            }
            else
            {
                return NotFound($"Macarrão com molho {molho} não encontrado.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(Macarrao macarrao)
        {
            macarraoList.Add(macarrao);
            return Created("", macarrao);
        }

        [HttpDelete]
        [Route("excluir/{molho}")]
        public IActionResult Excluir([FromRoute] string molho)
        {
            if (molho == null)
            {
                return BadRequest("O molho do macarrão não pode ser nulo.");
            }

            Macarrao? macarrao = macarraoList.Find(m => m.Nome == molho);

            if (macarrao != null)
            {
                macarraoList.Remove(macarrao);
                return Ok($"Macarrão com molho {molho} excluído com sucesso.");
            }
            else
            {
                return NotFound($"Macarrão com molho {molho} não encontrado.");
            }
        }
    }
}
