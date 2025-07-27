using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations; // Importado para usar as anotações de validação (DataAnnotations)
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMvcFuncional.Models
{
    public class Aluno
    {
        [Key] // Chave da Model
        public int Id { get; set; }

        [Required(ErrorMessage = "0 campo {0} é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "0 campo {0} precisa ter entre {2} e {1} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} está em formato incorreto")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(60, ErrorMessage = "0 campo {0} precisa ter no máximo {1} caracteres")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "0 campo {0} está em formato inválido.")]
        //[EmailAddress(ErrorMessage = "O campo {0} está em formato inválido.")] - 2 formas de validar o e-mail
        public string? Email { get; set; }

        [Required(ErrorMessage = "0 campo {0} é obrigatório")]
        [Display(Name = "Confirme o e-mail")]
        [Compare("Email", ErrorMessage = "Os e-mails informados não são identicos")]
        [NotMapped] // Não mapear para o banco de dados
        public string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "0 campo {0} é obrigatório")]
        [Range(1, 5, ErrorMessage = "O campo {0} deve estar entre {1} e {2}")]
        public int Avaliacao { get; set; }

        public bool Ativo { get; set; }
    }
}
