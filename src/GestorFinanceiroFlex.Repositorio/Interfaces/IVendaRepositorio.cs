using GestaoFinanceiroFlex.Dominio.Entidades;

namespace GestorFinanceiroFlex.Repositorio.Interfaces
{
    public interface IVendaRepositorio
    {
        List<Venda> ObterVendasPorCliente(Guid clienteId);
    }
}
