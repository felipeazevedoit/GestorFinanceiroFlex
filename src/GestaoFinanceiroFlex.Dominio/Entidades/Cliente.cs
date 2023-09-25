namespace GestaoFinanceiroFlex.Dominio.Entidades
{
    public class Cliente:Base
    {
        public string? Nome { get; set; }
        public string? CpfCnpj { get; set; }
        public decimal CapitalSocial { get; set; }
    }

}
