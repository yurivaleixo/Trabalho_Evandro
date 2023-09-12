using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlindadoController : ControllerBase
    {
        private static List<Blindado> blindados = new();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(blindados);
        }

        [HttpGet]
        [Route("buscar/{nome}")]
        public IActionResult Buscar([FromRoute] string nome)
        {
            if (nome == null)
            {
                return BadRequest("O nome do blindado não pode ser nulo.");
            }

            Blindado? blindado = blindados.Find(b => b.Nome == nome);

            if (blindado != null)
            {
                return Ok(blindado);
            }
            else
            {
                return NotFound($"Blindado com o nome {nome} não encontrado.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(Blindado blindado)
        {
            blindados.Add(blindado);
            return Created("", blindado);
        }

        [HttpDelete]
        [Route("excluir/{nome}")]
        public IActionResult Excluir([FromRoute] string nome)
        {
            if (nome == null)
            {
                return BadRequest("O nome do blindado não pode ser nulo.");
            }

            Blindado? blindado = blindados.Find(b => b.Nome == nome);

            if (blindado != null)
            {
                blindados.Remove(blindado);
                return Ok($"Blindado com o nome {nome} excluído com sucesso.");
            }
            else
            {
                return NotFound($"Blindado com o nome {nome} não encontrado.");
            }
        }
    }
}
