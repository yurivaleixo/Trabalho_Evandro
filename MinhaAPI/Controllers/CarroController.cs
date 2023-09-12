using Microsoft.AspNetCore.Mvc;

namespace MinhaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{
   private static List<Carro> carros = new();

   [HttpGet()]
   [Route("listar")]

   public IActionResult Listar()
   {
    return Ok(carros);
   }

   [HttpGet()]
   [Route("buscar/{placa}")]

   public IActionResult Buscar([FromRoute] string placa)
   {
        Carro? carro = carros.Find(x => x.Placa != null && x.Placa == placa);
        if(carro != null)
            return Ok(carro);
        else 
            return NotFound();
   }

    [HttpPost()]
    [Route("inserir")]

    public IActionResult Inserir(Carro carro)
    {
        carros.Add(carro);
        return Created("", carro);
    }


   
}
