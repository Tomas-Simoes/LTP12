using System.ComponentModel.DataAnnotations;

namespace AppPizzaria.Models
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Pizza Pizza { get; set; } 
        public int Quantidade { get; set; }
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }    
    }
}
