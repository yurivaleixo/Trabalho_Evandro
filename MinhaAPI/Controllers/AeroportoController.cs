using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AeroportoController : ControllerBase
    {
        private static List<Aeroporto> aeroportos = new();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(aeroportos);
        }

        [HttpGet]
        [Route("buscar/{codigoIATA}")]
        public IActionResult Buscar([FromRoute] string codigoIATA)
        {
            if (codigoIATA == null)
            {
                return BadRequest("O código IATA não pode ser nulo.");
            }

            Aeroporto? aeroporto = aeroportos.Find(a => a.CodigoIATA == codigoIATA);

            if (aeroporto != null)
            {
                return Ok(aeroporto);
            }
            else
            {
                return NotFound($"Aeroporto com o código IATA {codigoIATA} não encontrado.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(Aeroporto aeroporto)
        {
            aeroportos.Add(aeroporto);
            return Created("", aeroporto);
        }

        [HttpDelete]
        [Route("excluir/{codigoIATA}")]
        public IActionResult Excluir([FromRoute] string codigoIATA)
        {
            if (codigoIATA == null)
            {
                return BadRequest("O código IATA não pode ser nulo.");
            }

            Aeroporto? aeroporto = aeroportos.Find(a => a.CodigoIATA == codigoIATA);

            if (aeroporto != null)
            {
                aeroportos.Remove(aeroporto);
                return Ok($"Aeroporto com o código IATA {codigoIATA} excluído com sucesso.");
            }
            else
            {
                return NotFound($"Aeroporto com o código IATA {codigoIATA} não encontrado.");
            }
        }
    }
}
