using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPratico1.Models
{
    [Table("Agencias")]
    public class Agencia
    {
        [Key]
        public int AgenciaId { get; set; }

        [StringLength(60, ErrorMessage = "O tamanho máximo é 60 caracteres")]
        [Required(ErrorMessage = "Insira a morada da agência")]
        [Display(Name = "Morada")]
        public string Morada { get; set; }

        public List<Conta> Contas { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }

    }
}
