using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SorveteController : ControllerBase
    {
        private static List<Sorvete> sorvetes = new();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(sorvetes);
        }

        [HttpGet]
        [Route("buscar/{sabor}")]
        public IActionResult Buscar([FromRoute] string sabor)
        {
            if (sabor == null)
            {
                return BadRequest("O sabor do sorvete não pode ser nulo.");
            }

            Sorvete? sorvete = sorvetes.Find(s => s.Sabor == sabor);

            if (sorvete != null)
            {
                return Ok(sorvete);
            }
            else
            {
                return NotFound($"Sorvete com sabor {sabor} não encontrado.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(Sorvete sorvete)
        {
            sorvetes.Add(sorvete);
            return Created("", sorvete);
        }

        [HttpDelete]
        [Route("excluir/{sabor}")]
        public IActionResult Excluir([FromRoute] string sabor)
        {
            if (sabor == null)
            {
                return BadRequest("O sabor do sorvete não pode ser nulo.");
            }

            Sorvete? sorvete = sorvetes.Find(s => s.Sabor == sabor);

            if (sorvete != null)
            {
                sorvetes.Remove(sorvete);
                return Ok($"Sorvete com sabor {sabor} excluído com sucesso.");
            }
            else
            {
                return NotFound($"Sorvete com sabor {sabor} não encontrado.");
            }
        }
    }
}
