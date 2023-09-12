using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComidaController : ControllerBase
    {
        private static List<Comida> comidas = new List<Comida>();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(comidas);
        }

        [HttpGet]
        [Route("buscar/{nome}")]
        public IActionResult Buscar([FromRoute] string nome)
        {
            if (nome == null)
            {
                return BadRequest("O nome da comida não pode ser nulo.");
            }

            Comida? comida = comidas.Find(c => c.Nome == nome);

            if (comida != null)
            {
                return Ok(comida);
            }
            else
            {
                return NotFound($"Comida com nome {nome} não encontrada.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(Comida comida)
        {
            comidas.Add(comida);
            return Created("", comida);
        }

        [HttpDelete]
        [Route("excluir/{nome}")]
        public IActionResult Excluir([FromRoute] string nome)
        {
            if (nome == null)
            {
                return BadRequest("O nome da comida não pode ser nulo.");
            }

            Comida? comida = comidas.Find(c => c.Nome == nome);

            if (comida != null)
            {
                comidas.Remove(comida);
                return Ok($"Comida com nome {nome} excluída com sucesso.");
            }
            else
            {
                return NotFound($"Comida com nome {nome} não encontrada.");
            }
        }
    }
}
