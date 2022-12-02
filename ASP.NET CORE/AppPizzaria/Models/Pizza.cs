using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPizzaria.Models
{
    [Table("Pizzas")]
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }

        [Required(ErrorMessage = "Tem de indicar o nome da Pizza")]
        [Display(Name = "Nome da Pizza")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no minimo {1} e no máximo {2} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Tem de indicar a descrição de Pizza")]
        [Display(Name ="Descrição da Pizza")]
        [MinLength(20,ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição não pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Tem de indicar a descrição detalhada de Pizza")]
        [Display(Name = "Descrição da Pizza")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada não pode exceder {1} caracteres")]

        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Indique o preço da Pizza")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]

        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem tamanho Normal " )]
        [StringLength(200, ErrorMessage = "o {0} deve ter no máximo {1} caracteres ")]

        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }


        [Display(Name = "Preferida?")]          
        public bool IsPizzaPreferida { get; set; }

        
        [Display(Name = "Em Stock?")]
        public bool EmStock { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categorias  { get; set; }
    }
}
