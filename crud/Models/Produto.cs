namespace crud.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string? Descricao { get; set; }
        public string? UnidadeMedida { get; set; }
        public int Estoque { get; set; }
        public decimal Custo { get; set; }
        public decimal ValorVenda { get; set; }
    }
}
