namespace GestaoFinanceiroFlex.Dominio.Entidades
{
    public class Produto : Base
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public string? Categoria { get; set; }
    }

}
