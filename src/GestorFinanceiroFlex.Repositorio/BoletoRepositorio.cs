using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Repositorio.Data;
using GestorFinanceiroFlex.Repositorio.Interfaces;

namespace GestorFinanceiroFlex.Repositorio
{
    public class BoletoRepositorio : IBoletoRepositorio
    {
        private readonly IContextoMemoria _contexto;


        public BoletoRepositorio(IContextoMemoria contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Boleto entidade)
        {
            entidade.Id = Guid.NewGuid();
            entidade.Ativo = true;
            _contexto.Boletos.Add(entidade);
        }

        public void Atualizar(Boleto entidade)
        {
            var boletoExistente = _contexto.Boletos.FirstOrDefault(b => b.Id == entidade.Id && b.Ativo);
            if (boletoExistente != null)
            {
                boletoExistente.ClienteId = entidade.ClienteId;
                boletoExistente.Valor = entidade.Valor;
                boletoExistente.DataVencimento = entidade.DataVencimento;
            }
        }

        public List<Boleto> ObterBoletosPorCliente(Guid clienteId)
        {
            return _contexto.Boletos.Where(b => b.Ativo && b.ClienteId == clienteId).ToList();
        }

        public Boleto ObterPorId(Guid id)
        {
            return _contexto.Boletos.FirstOrDefault(b => b.Id == id && b.Ativo);
        }

        public void Remover(Boleto entidade)
        {
            var boletoExistente = _contexto.Boletos.FirstOrDefault(b => b.Id == entidade.Id && b.Ativo);
            if (boletoExistente != null)
            {
                boletoExistente.Ativo = false; 
            }
        }
    }
}
