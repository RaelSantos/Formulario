using Formulario.MVC.Validators;
using System.ComponentModel.DataAnnotations;

namespace Formulario.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preecha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
                 
        [Mutual("Telefone", "Preencha o DDD e o Telefone")]
        public int? DDD { get; set; }
                
        [Mutual("DDD", "Preencha o DDD e o Telefone")]
        public int? Telefone { get; set; }

        [Required(ErrorMessage = "Preecha o E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}