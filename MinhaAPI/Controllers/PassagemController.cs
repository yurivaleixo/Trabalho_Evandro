using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassagemController : ControllerBase
    {
        private static List<Passagem> passagens = new();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(passagens);
        }

        [HttpGet]
        [Route("buscar/{destino}")]
        public IActionResult Buscar([FromRoute] string destino)
        {
            if (destino == null)
            {
                return BadRequest("O destino não pode ser nulo.");
            }

            Passagem? passagem = passagens.Find(p => p.Destino == destino);

            if (passagem != null)
            {
                return Ok(passagem);
            }
            else
            {
                return NotFound($"Passagem para {destino} não encontrada.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(Passagem passagem)
        {
            passagens.Add(passagem);
            return Created("", passagem);
        }

        [HttpDelete]
        [Route("excluir/{destino}")]
        public IActionResult Excluir([FromRoute] string destino)
        {
            if (destino == null)
            {
                return BadRequest("O destino não pode ser nulo.");
            }

            Passagem? passagem = passagens.Find(p => p.Destino == destino);

            if (passagem != null)
            {
                passagens.Remove(passagem);
                return Ok($"Passagem para {destino} excluída com sucesso.");
            }
            else
            {
                return NotFound($"Passagem para {destino} não encontrada.");
            }
        }
    }
}
