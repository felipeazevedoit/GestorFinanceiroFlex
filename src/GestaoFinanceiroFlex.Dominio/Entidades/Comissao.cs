using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceiroFlex.Dominio.Entidades
{
    public class Comissao : Base
    {
        public Venda Venda { get; set; }
        public decimal ValorComissao { get; set; }
    }
}
