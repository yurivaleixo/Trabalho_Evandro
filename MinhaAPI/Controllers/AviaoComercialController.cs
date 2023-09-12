using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AviaoComercialController : ControllerBase
    {
        private static List<AviaoComercial> avioesComerciais = new();

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(avioesComerciais);
        }

        [HttpGet]
        [Route("buscar/{modelo}")]
        public IActionResult Buscar([FromRoute] string modelo)
        {
            if (modelo == null)
            {
                return BadRequest("O modelo não pode ser nulo.");
            }

            AviaoComercial? aviaoComercial = avioesComerciais.Find(aviao => aviao.Modelo == modelo);

            if (aviaoComercial != null)
            {
                return Ok(aviaoComercial);
            }
            else
            {
                return NotFound($"Avião comercial com o modelo {modelo} não encontrado.");
            }
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(AviaoComercial aviaoComercial)
        {
            avioesComerciais.Add(aviaoComercial);
            return Created("", aviaoComercial);
        }

        [HttpDelete]
        [Route("excluir/{modelo}")]
        public IActionResult Excluir([FromRoute] string modelo)
        {
            if (modelo == null)
            {
                return BadRequest("O modelo não pode ser nulo.");
            }

            AviaoComercial? aviaoComercial = avioesComerciais.Find(aviao => aviao.Modelo == modelo);

            if (aviaoComercial != null)
            {
                avioesComerciais.Remove(aviaoComercial);
                return Ok($"Avião comercial com o modelo {modelo} excluído com sucesso.");
            }
            else
            {
                return NotFound($"Avião comercial com o modelo {modelo} não encontrado.");
            }
        }
    }
}
