using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPratico1.Models
{
    [Table("Emprestimos")]
    public class Emprestimo
    {
        [Key]
        public int EmprestimoId { get; set; }

        [Required(ErrorMessage = "Indique o valor do emprestimo")]
        [Display(Name = "Valor")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }


        public virtual Agencia Agencias { get; set; }
        public virtual Cliente Clientes { get; set; }
    }
}
