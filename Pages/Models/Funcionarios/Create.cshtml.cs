using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExercicioAutoEscola.Data;
using ExercicioAutoEscola.Pages.Models.Funcionarios;

namespace ExercicioAutoEscola.Pages.Models.Funcionarios
{
    public class CreateModel : PageModel
    {
        private readonly ExercicioAutoEscola.Data.ExercicioAutoEscolaContext _context;

        public CreateModel(ExercicioAutoEscola.Data.ExercicioAutoEscolaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        [BindProperty]
        public Funcionario Funcionario { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Funcionario.Add(Funcionario);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
