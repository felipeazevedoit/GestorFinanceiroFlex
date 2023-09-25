using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceiroFlex.Dominio.Entidades
{
    public class Fatura : Base
    {
        public int ClienteId { get; set; }
        public decimal Valor { get; set; }
        public bool Processada { get; set; }
        public DateTime? DataProcessamento { get; set; }
    }
}
