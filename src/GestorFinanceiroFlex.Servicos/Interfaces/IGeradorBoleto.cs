using GestaoFinanceiroFlex.Dominio.Entidades;

namespace GestorFinanceiroFlex.Servicos.Interfaces
{
    public interface IGeradorBoleto
    {
        public Boleto GerarBoleto(Cliente cliente, DateTime dataVencimento, decimal valor);
    }
}
