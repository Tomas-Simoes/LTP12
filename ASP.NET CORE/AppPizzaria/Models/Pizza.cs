namespace AppPizzaria.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsPizzaPreferida { get; set; }
        public bool EmStock { get; set; }
        public int CategoriaId { get; set; }

    }
}
