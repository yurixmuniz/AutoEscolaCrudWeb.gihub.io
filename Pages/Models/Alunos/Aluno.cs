using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAutoEscola.Pages.Models.Alunos
{
    public class Aluno
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public string Treinamento { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [EmailAddress]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
