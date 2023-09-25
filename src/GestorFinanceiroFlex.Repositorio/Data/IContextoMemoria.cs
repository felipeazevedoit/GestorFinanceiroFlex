using GestaoFinanceiroFlex.Dominio.Entidades;

namespace GestorFinanceiroFlex.Repositorio.Data
{
    public interface IContextoMemoria
    {
        List<Cliente> Clientes { get; }
        List<Produto> Produtos { get; }
        List<Venda> Vendas { get; }
        List<Boleto> Boletos { get; }
        List<Comissao> Comissoes { get; }
        List<Cobranca> Cobrancas { get; }
        List<Fatura> Faturas { get; }

    }

}
