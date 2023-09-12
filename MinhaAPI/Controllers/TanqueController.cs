using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TanqueController : ControllerBase
    {
        private static List<Tanque> tanques = new();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(tanques);
        }

        [HttpGet]
        [Route("buscar/{nacionalidade}")]
        public IActionResult Buscar([FromRoute] string nacionalidade)
        {
            if (nacionalidade == null)
            {
                return BadRequest("O nacionalidade não pode ser nulo.");
            }

            Tanque? tanque = tanques.Find(t => t.Nacionalidade == nacionalidade);

            if (tanque != null)
            {
                return Ok(tanque);
            }
            else
            {
                return NotFound($"Tanque {nacionalidade} não encontrado.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(Tanque tanque)
        {
            tanques.Add(tanque);
            return Created("", tanque);
        }

        [HttpDelete]
        [Route("excluir/{nacionalidade}")]
        public IActionResult Excluir([FromRoute] string nacionalidade)
        {
            if (nacionalidade == null)
            {
                return BadRequest("O nacionalidade não pode ser nulo.");
            }

            Tanque? tanque = tanques.Find(t => t.Nome == nacionalidade);

            if (tanque != null)
            {
                tanques.Remove(tanque);
                return Ok($"Tanque {nacionalidade} excluído com sucesso.");
            }
            else
            {
                return NotFound($"Tanque {nacionalidade} não encontrado.");
            }
        }
    }
}
