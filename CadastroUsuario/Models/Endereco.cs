using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuario.Models
{
    public class Endereco 
    {

        [Required(ErrorMessage = "Campo Cep ou cnpj obrigatório")]
        [MinLength(3)]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Campo Bairro ou cnpj obrigatório")]
        [MinLength(3)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo Logradouro obrigatório")]
        [MinLength(3)]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }
    }
}
