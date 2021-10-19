using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAutoEscola.Pages.Models.Funcionarios
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [Display(Name ="Função")]
        public string Funcao { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [EmailAddress]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
