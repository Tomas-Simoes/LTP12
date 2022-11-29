using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPizzaria.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho maximo e 100 caracteres")]
        [Required(ErrorMessage = "Insira o nome da categoria")]
        [Display(Name = "Nome")]

        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho maximo e 200 caracteres")]
        [Required(ErrorMessage = "Insira a descricao da categoria")]
        [Display(Name = "Descricao")]

        public string Descricao { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
