namespace GestaoFinanceiroFlex.Dominio.Entidades
{
    public class Venda: Base
    {
        public Cliente? Cliente { get; set; }
        public Produto? Produto { get; set; }
        public DateTime? DataVenda { get; set; }
        public decimal ValorVenda { get; set; }
        public int ValorTotal { get; set; }
    }
}
