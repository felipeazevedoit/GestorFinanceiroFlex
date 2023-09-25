using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Repositorio.Data;
using GestorFinanceiroFlex.Repositorio.Interfaces;

namespace GestorFinanceiroFlex.Repositorio
{
    public class FaturaRepositorio : IFaturaRepositorio
    {
        private readonly IContextoMemoria _contexto;

        public FaturaRepositorio(IContextoMemoria contexto)
        {
            _contexto = contexto;
        }
        public void Adicionar(Fatura entidade)
        {
            entidade.Id = Guid.NewGuid();
            entidade.Ativo = true;
            _contexto.Faturas.Add(entidade);
        }

        public void Atualizar(Fatura entidade)
        {
            var faturaExistente = _contexto.Faturas.FirstOrDefault(f => f.Id == entidade.Id && f.Ativo);
            if (faturaExistente != null)
            {
                faturaExistente.Valor = entidade.Valor;
                faturaExistente.Processada = entidade.Processada;
            }
        }

        public List<Fatura> ObterFaturasNaoProcessadas()
        {
            return _contexto.Faturas.Where(f => f.Ativo && !f.Processada).ToList();
        }

        public Fatura ObterPorId(Guid id)
        {
            return _contexto.Faturas.FirstOrDefault(f => f.Id == id && f.Ativo);
        }

        public void Remover(Fatura entidade)
        {
            var faturaExistente = _contexto.Faturas.FirstOrDefault(f => f.Id == entidade.Id && f.Ativo);
            if (faturaExistente != null)
            {
                faturaExistente.Id = entidade.Id;
            }
        }
    }
}
