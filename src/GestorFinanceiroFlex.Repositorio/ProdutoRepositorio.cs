using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Repositorio.Data;
using GestorFinanceiroFlex.Repositorio.Interfaces;

namespace GestorFinanceiroFlex.Repositorio
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {
        private readonly IContextoMemoria _contexto;

        public ProdutoRepositorio(IContextoMemoria contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Produto entidade)
        {
            entidade.Ativo = true;
            entidade.AlteracaoAt = DateTime.Now;
            _contexto.Produtos.Add(entidade);
        }

        public void Atualizar(Produto entidade)
        {
            var produtoExistente = _contexto.Produtos.FirstOrDefault(p => p.Id == entidade.Id && p.Ativo);
            if (produtoExistente != null)
            {
                // Atualizar os campos relevantes do produto existente com os dados do produto passado como argumento.
                produtoExistente.Nome = entidade.Nome;
                produtoExistente.Preco = entidade.Preco;
                produtoExistente.Categoria = entidade.Categoria;
                produtoExistente.AlteracaoAt = DateTime.Now;
                
            }
        }

        public Produto ObterPorId(Guid id)
        {
            return _contexto.Produtos.FirstOrDefault(p => p.Id == id && p.Ativo);
        }

        public void Remover(Produto entidade)
        {
            var produtoExistente = _contexto.Produtos.FirstOrDefault(p => p.Id == entidade.Id && p.Ativo);
            if (produtoExistente != null)
            {
                produtoExistente.Ativo = false; // Marca o produto como inativo em vez de removê-lo fisicamente.
                produtoExistente.AlteracaoAt = DateTime.Now;
            }
        }
    }
}
