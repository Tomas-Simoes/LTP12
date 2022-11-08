using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPizzaria.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Insira o nome da categoria")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
