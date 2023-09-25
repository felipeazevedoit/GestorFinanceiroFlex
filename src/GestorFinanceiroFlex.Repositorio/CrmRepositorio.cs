using GestaoFinanceiroFlex.Dominio.Entidades;
using GestorFinanceiroFlex.Repositorio.Data;
using GestorFinanceiroFlex.Repositorio.Interfaces;

namespace GestorFinanceiroFlex.Repositorio
{
    public class CrmRepositorio : ICrmRepositorio
    {
        private readonly IContextoMemoria _contexto;
        private readonly IFaturaRepositorio _fatura;

        public CrmRepositorio(IContextoMemoria contexto, IFaturaRepositorio fatura)
        {
            _contexto = contexto;
            _fatura = fatura;
        }

        public bool ProcessarBaixaFatura(Fatura fatura)
        {
            if (fatura == null)
                throw new ArgumentNullException(nameof(fatura), "A fatura não pode ser nula.");

            // Verificar se a fatura já foi processada.
            if (fatura.Processada)
            {
                Console.WriteLine($"A fatura {fatura.Id} já foi processada no módulo CRM.");
                return true;
            }

            fatura.Processada = true;
            fatura.DataProcessamento = DateTime.Now;

            _fatura.Atualizar(fatura);
            return true;
        }
    }
}
