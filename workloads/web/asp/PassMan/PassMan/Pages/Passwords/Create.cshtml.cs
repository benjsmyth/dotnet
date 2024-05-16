using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PassMan.Data;
using PassMan.Models;

namespace PassMan.Pages.Passwords
{
    public class CreateModel : PageModel
    {
        private readonly PassMan.Data.PassManContext _context;

        public CreateModel(PassMan.Data.PassManContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Password Password { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Password.Add(Password);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
