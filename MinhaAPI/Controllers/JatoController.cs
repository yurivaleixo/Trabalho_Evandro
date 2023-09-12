using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JatoController : ControllerBase
    {
        private static List<Jato> jatos = new List<Jato>();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(jatos);
        }

        [HttpGet]
        [Route("buscar/{nome}")]
        public IActionResult Buscar([FromRoute] string nome)
        {
            if (nome == null)
            {
                return BadRequest("O nome do jato não pode ser nulo.");
            }

            Jato? jato = jatos.Find(j => j.Nome == nome);

            if (jato != null)
            {
                return Ok(jato);
            }
            else
            {
                return NotFound($"Jato com o nome {nome} não encontrado.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(Jato jato)
        {
            jatos.Add(jato);
            return Created("", jato);
        }

        [HttpDelete]
        [Route("excluir/{nome}")]
        public IActionResult Excluir([FromRoute] string nome)
        {
            if (nome == null)
            {
                return BadRequest("O nome do jato não pode ser nulo.");
            }

            Jato? jato = jatos.Find(j => j.Nome == nome);

            if (jato != null)
            {
                jatos.Remove(jato);
                return Ok($"Jato com o nome {nome} excluído com sucesso.");
            }
            else
            {
                return NotFound($"Jato com o nome {nome} não encontrado.");
            }
        }
    }
}
