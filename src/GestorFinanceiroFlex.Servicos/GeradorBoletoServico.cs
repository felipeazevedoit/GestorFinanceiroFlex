using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Repositorio.Interfaces;
using GestorFinanceiroFlex.Servicos.Interfaces;

namespace GestorFinanceiroFlex.Servicos
{


    public class GeradorBoletoServico : IGeradorBoleto
    {

        private readonly IBoletoRepositorio _repositorioBoleto;

        public GeradorBoletoServico()
        {
        }

        public GeradorBoletoServico(IBoletoRepositorio repositorioBoleto)
        {
            _repositorioBoleto = repositorioBoleto;
        }

        public Boleto GerarBoleto(Cliente cliente, DateTime dataVencimento, decimal valor)
        {
            Boleto boleto = new()
            {
                ClienteId = cliente.Id,
                Valor = valor,
                DataVencimento = DateTime.Now.AddDays(30), // Exemplo de data de vencimento (30 dias a partir de hoje).
            };
            _repositorioBoleto.Adicionar(boleto);
            return boleto;
        }
    }
}
