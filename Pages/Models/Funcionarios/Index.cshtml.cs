using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExercicioAutoEscola.Data;
using ExercicioAutoEscola.Pages.Models.Alunos;

namespace ExercicioAutoEscola.Pages.Models.Funcionarios
{
    public class IndexModel : PageModel
    {
        private readonly ExercicioAutoEscola.Data.ExercicioAutoEscolaContext _context;

        public IndexModel(ExercicioAutoEscola.Data.ExercicioAutoEscolaContext context)
        {
            _context = context;
        }

        public IList<Funcionario> Funcionario { get;set; }

        public async Task OnGetAsync()
        {
            Funcionario = await _context.Funcionario.ToListAsync();
        }
    }
}
