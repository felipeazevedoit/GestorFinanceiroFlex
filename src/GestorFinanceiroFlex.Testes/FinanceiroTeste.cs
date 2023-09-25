using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Repositorio.Interfaces;
using GestorFinanceiroFlex.Servicos;

namespace GestorFinanceiroFlex.Testes
{
    public class FinanceiroTeste
    {
        [Fact]
        public void CalcularComissao_DeveCalcularComissaoCorretamente()
        {
            var venda = new Venda { ValorTotal = 1000 };


            var calculadoraComissao = new CalculadoraComissaoServico(vendaRepositorioMock.Object);
            
            decimal comissaoEsperada = 150; // (1000 * 0.05) + (2000 * 0.1) + (3000 * 0.15)

            decimal resultadoComissao = calculadoraComissao.CalcularComissao(venda);

            Assert.Equal(comissaoEsperada, resultadoComissao);
        }

        [Fact]
        public void GerarBoleto_DeveGerarBoletoCorretamente()
        {
            var cliente = new Cliente
            {
                Id = Guid.NewGuid(),
                Ativo = true,
                CpfCnpj = "39225874588",
                CadastroAt = DateTime.Now,
                Nome = "José da Silva"
            };
            var valor = 1000;
            var vencimento = DateTime.Now;

            var geradorBoletoService = new GeradorBoletoServico();

            Boleto boletoGerado = geradorBoletoService.GerarBoleto(cliente, vencimento, valor);

            Assert.NotNull(boletoGerado);
            Assert.Equal(valor, boletoGerado.Valor);
            Assert.Equal(vencimento, boletoGerado.DataVencimento);
        }
    }
}