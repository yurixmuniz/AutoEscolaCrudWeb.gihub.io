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
    public class DetailsModel : PageModel
    {
        private readonly ExercicioAutoEscola.Data.ExercicioAutoEscolaContext _context;

        public DetailsModel(ExercicioAutoEscola.Data.ExercicioAutoEscolaContext context)
        {
            _context = context;
        }

        public Funcionario Funcionario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario = await _context.Funcionario.FirstOrDefaultAsync(m => m.ID == id);

            if (Funcionario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
