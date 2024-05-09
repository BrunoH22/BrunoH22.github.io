using System.ComponentModel.DataAnnotations;
using static BDestoque.Data.Usuario;

namespace BDestoque.Models
{
    public class UsuarioViewModel
    {
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


    }
}
