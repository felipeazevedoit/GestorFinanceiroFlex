using GestaoFinanceiroFlex.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFinanceiroFlex.Repositorio.Data
{
    public class ContextoMemoria : IContextoMemoria
    {
        public List<Cliente> Clientes { get; private set; }
        public List<Produto> Produtos { get; private set; }
        public List<Venda> Vendas { get; private set; }
        public List<Boleto> Boletos { get; private set; }
        public List<Comissao> Comissoes { get; private set; }
        public List<Cobranca> Cobrancas { get; private set; }
        public List<Fatura> Faturas { get; private set; }


        public ContextoMemoria()
        {
            // Inicialize listas fictícias de dados para cada entidade
            Clientes = new List<Cliente>
        {
            new Cliente { Id = Guid.NewGuid(), Nome = "Cliente 1", CpfCnpj = "1234567890", CapitalSocial = 10000 },
            new Cliente { Id = Guid.NewGuid(), Nome = "Cliente 2", CpfCnpj = "9876543210", CapitalSocial = 15000 }
        };

            Produtos = new List<Produto>
        {
            new Produto { Id = Guid.NewGuid(), Nome = "Produto A", Preco = 50, Categoria = "Categoria 1" },
            new Produto { Id = Guid.NewGuid(), Nome = "Produto B", Preco = 75, Categoria = "Categoria 2" }
        };

            Vendas = new List<Venda>
        {
            new Venda { Id = Guid.NewGuid(), Cliente = Clientes[0], Produto = Produtos[0], DataVenda = DateTime.Now, ValorVenda = 500 },
            new Venda { Id = Guid.NewGuid(), Cliente = Clientes[1], Produto = Produtos[1], DataVenda = DateTime.Now, ValorVenda = 750 }
        };

            Boletos = new List<Boleto>
        {
            new Boleto { Id = Guid.NewGuid(), Cliente = Clientes[0], DataVencimento = DateTime.Now.AddDays(30), Valor = 500 },
            new Boleto { Id = Guid.NewGuid(), Cliente = Clientes[1], DataVencimento = DateTime.Now.AddDays(30), Valor = 750 }
        };

            Comissoes = new List<Comissao>
        {
            new Comissao { Id = Guid.NewGuid(), Venda = Vendas[0], ValorComissao = 50 },
            new Comissao { Id = Guid.NewGuid(), Venda = Vendas[1], ValorComissao = 75 }
        };

            Cobrancas = new List<Cobranca>
        {
            new Cobranca { Id = Guid.NewGuid(), Cliente = Clientes[0], Valor = 500, DataCobranca = DateTime.Now },
            new Cobranca { Id = Guid.NewGuid(), Cliente = Clientes[1], Valor = 750, DataCobranca = DateTime.Now }
        };

        }
    }
}
