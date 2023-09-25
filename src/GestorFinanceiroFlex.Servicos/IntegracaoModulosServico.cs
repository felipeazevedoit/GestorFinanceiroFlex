using GestaoFinanceiroFlex.Dominio.Entidades;
using GestaoFinanceiroFlex.Dominio.Interfaces;
using GestorFinanceiroFlex.Repositorio.Interfaces;

namespace GestorFinanceiroFlex.Servicos
{
    public class IntegracaoModulosServico : IIntegracaoModulos
    {
        private readonly IFaturaRepositorio _FaturaRepositorio;
        private readonly ICrmRepositorio _CrmRepositorio;

        public IntegracaoModulosServico(IFaturaRepositorio fatura, ICrmRepositorio crmRepositorio )
        {
            _CrmRepositorio = crmRepositorio;
            _FaturaRepositorio = fatura;
            
        }


        public void AtualizarOperacoesComercial(Fatura fatura)
        {
            var fat = _FaturaRepositorio.ObterPorId(fatura.Id) ?? throw new Exception("Fatura não encontrada.");
            _CrmRepositorio.ProcessarBaixaFatura(fat);
        }
    }
}
