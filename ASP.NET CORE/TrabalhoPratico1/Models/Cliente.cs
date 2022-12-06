using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPratico1.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [StringLength(35, ErrorMessage = "O tamanho máximo é 35 caracteres")]
        [Required(ErrorMessage = "Insira o nome do cliente")]
        [Display(Name = "Nome")]
        public string ClienteNome { get; set; }

        [StringLength(60, ErrorMessage = "O tamanho máximo é 60 caracteres")]
        [Required(ErrorMessage = "Insira a morada do cliente")]
        [Display(Name = "Morada")]
        public string Morada { get; set; }

        public List<Conta> Contas { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }
}
