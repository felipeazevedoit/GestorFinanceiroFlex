using GestaoFinanceiroFlex.Dominio.Entidades;
using GestaoFinanceiroFlex.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestorFinanceiroFlex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComissaoController : ControllerBase
    {
        private readonly ICalculadoraComissao _calculadoraComissao;

        public ComissaoController(ICalculadoraComissao calculadoraComissao)
        {
            _calculadoraComissao = calculadoraComissao;
        }

        [HttpPost("calcular-comissao")]
        public IActionResult CalcularComissao([FromBody] Venda venda)
        {
            try
            {
                decimal comissao = _calculadoraComissao.CalcularComissao(venda);
                return Ok(new { Comissao = comissao });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Mensagem = "Erro ao calcular comissão.", Detalhes = ex.Message });
            }
        }
    }
}
