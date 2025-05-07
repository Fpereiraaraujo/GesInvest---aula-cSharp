namespace GestInvest.Models
{
    public class Acao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public DateTime DataCompra { get; set; }
        public string Moeda { get; set; }
        public decimal Preco { get; set; }
    }
}
