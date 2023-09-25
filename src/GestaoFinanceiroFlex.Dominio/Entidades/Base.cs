namespace GestaoFinanceiroFlex.Dominio.Entidades
{
    public abstract class Base
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime CadastroAt { get; set;}
        public DateTime AlteracaoAt { get; set; }

        public Base()
        {
       
        }
        
    }
}
