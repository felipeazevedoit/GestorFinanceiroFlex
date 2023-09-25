namespace GestaoFinanceiroFlex.Dominio.Entidades
{
    public class Boleto: Base
    {
        public Cliente Cliente { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal Valor { get; set; }
        public Guid ClienteId { get; set; }

        public Boleto()
        {
            
        }
        public Boleto(Cliente cliente, DateTime dataVencimento, decimal valor)
        {
            this.Cliente = cliente;
            DataVencimento = dataVencimento;
            Valor = valor;
        }
    }
}
