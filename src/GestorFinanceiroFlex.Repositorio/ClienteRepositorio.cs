using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Repositorio.Data;
using GestorFinanceiroFlex.Repositorio.Interfaces;

namespace GestorFinanceiroFlex.Repositorio
{
    public class ClienteRepositorio : IRepositorio<Cliente>
    {
        private readonly IContextoMemoria _contexto;

        public ClienteRepositorio(IContextoMemoria contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Cliente entidade)
        {
            entidade.Id = Guid.NewGuid();
            _contexto.Clientes.Add(entidade);
        }

        public void Atualizar(Cliente entidade)
        {
            var clienteExistente = _contexto.Clientes.FirstOrDefault(c => c.Id == entidade.Id && c.Ativo);
            if (clienteExistente != null)
            {
                clienteExistente.Nome = entidade.Nome;
                clienteExistente.CpfCnpj = entidade.CpfCnpj;
                clienteExistente.CapitalSocial = entidade.CapitalSocial;
                clienteExistente.AlteracaoAt = DateTime.Now;
            }
        }

        public Cliente ObterPorId(Guid id)
        {
            return _contexto.Clientes.FirstOrDefault(c => c.Id == id && c.Ativo);
        }

        public void Remover(Cliente entidade)
        {
            var clienteExistente = _contexto.Clientes.FirstOrDefault(c => c.Id == entidade.Id && c.Ativo);
            if (clienteExistente != null)
            {
                clienteExistente.Ativo = false;
                clienteExistente.AlteracaoAt = DateTime.Now;
            }
        }
    }
}
