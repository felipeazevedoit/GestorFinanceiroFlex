using GestaoFinanceiroFlex.Dominio.Entidades;
using GestaoFinanceiroFlex.Dominio.Interfaces;

namespace GestorFinanceiroFlex.Servicos
{
    public class CalculadoraComissaoServico : ICalculadoraComissao
    {
        public decimal CalcularComissao(Venda venda)
        {
            return venda.ValorVenda * 0.1m; // 10% do valor da venda como comissão        }
        }
    }
}
