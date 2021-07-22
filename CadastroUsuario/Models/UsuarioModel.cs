using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuario.Models
{
    public class Usuario : Endereco
    {
   
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Nome obrigatório")]
        [MinLength(3)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Sobre Nome obrigatório")]
        [MinLength(3)]
        [Display(Name = "Sobrenome")]
        public string SobreNome { get; set; }

        [Display(Name = "Salário")]
        [DataType(DataType.Currency)]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Campo CPF obrigatório")]
        [MinLength(9)]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
    }
}
