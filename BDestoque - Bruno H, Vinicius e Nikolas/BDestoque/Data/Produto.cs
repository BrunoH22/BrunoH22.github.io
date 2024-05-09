using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDestoque.Data
{

    [Table("Produtos")]

    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(20)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Tipo obrigatório")]
        [StringLength(20)]
        public string Tipo{ get; set; }

        [Required(ErrorMessage ="Informe uma quantidade")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage ="Valor obrigatório")]
        [DataType(DataType.Currency)]
        public double Valor { get; set; }

        
    }
}
