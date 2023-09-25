using GestaoFinanceiroFlex.Dominio.Entidades;

namespace GestaoFinanceiroFlex.Dominio.Interfaces
{
    public interface ICalculadoraComissao
    {
        decimal CalcularComissao(Venda venda);
    }
}
