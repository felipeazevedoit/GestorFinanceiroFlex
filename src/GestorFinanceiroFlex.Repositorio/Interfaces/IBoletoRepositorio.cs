using GestaoFinanceiroFlex.Dominio.Entidades;

namespace GestorFinanceiroFlex.Repositorio.Interfaces
{
    public interface IBoletoRepositorio : IRepositorio<Boleto>
    {
        List<Boleto> ObterBoletosPorCliente(Guid clienteId);
    }
}
