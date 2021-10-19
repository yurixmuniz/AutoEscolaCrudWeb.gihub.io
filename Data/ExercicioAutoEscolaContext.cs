using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExercicioAutoEscola.Pages.Models.Alunos;
using ExercicioAutoEscola.Pages.Models.Funcionarios;

namespace ExercicioAutoEscola.Data
{
    public class ExercicioAutoEscolaContext : DbContext
    {
        public ExercicioAutoEscolaContext (DbContextOptions<ExercicioAutoEscolaContext> options)
            : base(options)
        {
        }

        public DbSet<ExercicioAutoEscola.Pages.Models.Funcionarios.Funcionario> Funcionario { get; set; }

        public DbSet<ExercicioAutoEscola.Pages.Models.Alunos.Aluno> Aluno { get; set; }
    }
}
