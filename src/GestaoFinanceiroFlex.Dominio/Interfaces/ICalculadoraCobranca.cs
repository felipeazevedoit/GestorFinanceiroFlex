using GestaoFinanceiroFlex.Dominio.Entidades;

namespace GestaoFinanceiroFlex.Dominio.Interfaces
{
    public interface ICalculadoraCobranca
    {
        decimal CalcularCobranca(Cliente cliente);
    }

}
