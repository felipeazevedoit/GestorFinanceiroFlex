namespace GestorFinanceiroFlex.Repositorio.Interfaces
{
    public interface IRepositorio<T>
    {
        T ObterPorId(Guid id);
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Remover(T entidade);
    }
}
