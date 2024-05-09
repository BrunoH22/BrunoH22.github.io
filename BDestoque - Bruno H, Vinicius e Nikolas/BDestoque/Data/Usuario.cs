using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDestoque.Data
{

    [Table("Usuarios")]

    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Senha obrigatória")]
        [StringLength(100)]
        [DataType(DataType.Password, ErrorMessage = "Informe uma senha válida")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Perfil obrigatório")]
        [Display(Name = "Perfil do usuário")]
        public PerfilUsuario Perfil { get; set; }

        //relacionamento 1-1


        public enum PerfilUsuario
        {
            Administrador = 2,
        }
    }





}

