using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Repositorio.Data;
using GestorFinanceiroFlex.Repositorio.Interfaces;

namespace GestorFinanceiroFlex.Repositorio
{
    public class VendaRepositorio : IRepositorio<Venda>, IVendaRepositorio
    {

    private readonly IContextoMemoria _contexto;
        public VendaRepositorio(IContextoMemoria contexto)
        {
            _contexto = contexto;
        }


        public void Adicionar(Venda entidade)
        {
            entidade.Ativo = true;
            entidade.DataVenda = DateTime.Now;
            _contexto.Vendas.Add(entidade);
        }

        public void Atualizar(Venda entidade)
        {
            var vendaExistente = _contexto.Vendas.FirstOrDefault(v => v.Id == entidade.Id && v.Ativo);
            if (vendaExistente != null)
            {
                vendaExistente.Cliente = entidade.Cliente;
                vendaExistente.Produto = entidade.Produto;
                vendaExistente.ValorVenda = entidade.ValorVenda;
                vendaExistente.AlteracaoAt = DateTime.Now;
            }
        }

        public Venda ObterPorId(Guid id)
        {
            return _contexto.Vendas.FirstOrDefault(v => v.Id == id && v.Ativo);
        }

        public List<Venda> ObterVendasPorCliente(Guid clienteId)
        {
            return _contexto.Vendas.Where(v => v.Ativo && v.Cliente.Id == clienteId).ToList();
        }

        public void Remover(Venda entidade)
        {
            var vendaExistente = _contexto.Vendas.FirstOrDefault(v => v.Id == entidade.Id && v.Ativo);
            if (vendaExistente != null)
            {
                vendaExistente.Ativo = false; 
                vendaExistente.AlteracaoAt = DateTime.Now;
            }
        }
    }
}
