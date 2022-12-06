using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPratico1.Models
{
    [Table("Contas")]
    public class Conta
    {
        [Key]
        public int ContaId { get; set; }

        [Required(ErrorMessage = "Indique o saldo do cliente")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }

        public int AgenciaId { get; set; }
        public int ClienteId { get; set; }


        public virtual Agencia Agencias { get; set; }
        public virtual Cliente Clientes { get; set; }

    }
}
