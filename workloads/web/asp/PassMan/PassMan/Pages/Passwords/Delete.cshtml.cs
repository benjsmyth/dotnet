using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PassMan.Data;
using PassMan.Models;

namespace PassMan.Pages.Passwords
{
    public class DeleteModel : PageModel
    {
        private readonly PassMan.Data.PassManContext _context;

        public DeleteModel(PassMan.Data.PassManContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Password Password { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var password = await _context.Password.FirstOrDefaultAsync(m => m.Id == id);

            if (password == null)
            {
                return NotFound();
            }
            else
            {
                Password = password;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var password = await _context.Password.FindAsync(id);
            if (password != null)
            {
                Password = password;
                _context.Password.Remove(Password);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
