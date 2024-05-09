using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace BDestoque.Data
{

    [Table("MovimentacaoProdutos")]
    public class MoviPro
    {
        //Propriedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        //Relacionamento 1-N
        [Display(Name = "Produto")]
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }


        //Relacionamento 1-1
        [ForeignKey("Usuario")]
        [Display(Name = "Codigo")]
        public int IdUsuario { get; set; }

        public virtual Usuario Usuario { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Data movimentação")]
        
        public DateTime DataMovi { get; set; }

        [Required(ErrorMessage = "Informe uma quantidade")]
        public int Quantidade { get; set; }


    }
}
