using GestaoFinanceiroFlex.Dominio.Entidades;
using GestaoFinanceiroFlex.Dominio.Interfaces;

namespace GestorFinanceiroFlex.Servicos
{
    public class CalculadoraComissaoServico : ICalculadoraComissao
    {
        private object @object;

        public CalculadoraComissaoServico(object @object)
        {
            this.@object = @object;
        }

        public decimal CalcularComissao(Venda venda)
        {
            return venda.ValorTotal * 0.1m; // 10% do valor da venda como comissão        }
        }
    }
}
