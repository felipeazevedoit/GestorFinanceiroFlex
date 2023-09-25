using GestaoFinanceiroFlex.Dominio.Entidades;
using GestaoFinanceiroFlex.Dominio.Interfaces;

namespace GestorFinanceiroFlex.Servicos
{
    public class CalculadoraCobrancaServico : ICalculadoraCobranca
    {
        public decimal CalcularCobranca(Cliente cliente)
        {
            return cliente.CapitalSocial * 0.05m; // 5% do capital social como cobrança        }
        }
    }
}
