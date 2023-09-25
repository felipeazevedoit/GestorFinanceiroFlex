using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestorFinanceiroFlex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoletoController : ControllerBase
    {
        private readonly IGeradorBoleto _geradorBoleto;

        public BoletoController(IGeradorBoleto geradorBoleto)
        {
            _geradorBoleto = geradorBoleto;
        }

        [HttpPost("gerar-boleto")]
        public IActionResult GerarBoleto([FromBody] Cliente cliente, DateTime dataVencimento, decimal valor)
        {
            try
            {
                Boleto boleto = _geradorBoleto.GerarBoleto(cliente, dataVencimento, valor);
                return Ok(boleto);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Mensagem = "Erro ao gerar boleto.", Detalhes = ex.Message });
            }
        }
    }
}
