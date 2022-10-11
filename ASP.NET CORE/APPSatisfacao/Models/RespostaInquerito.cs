namespace APPSatisfacao.Models
{
    public class RespostaInquerito
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateOnly DataCompra { get; set; }
        public string Produto { get; set; }
        public bool Satisfacao { get; set; }
    }
}
