using GestaoFinanceiroFlex.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFinanceiroFlex.Repositorio.Interfaces
{
    public interface IFaturaRepositorio : IRepositorio<Fatura>
    {
        List<Fatura> ObterFaturasNaoProcessadas();
    }
}
