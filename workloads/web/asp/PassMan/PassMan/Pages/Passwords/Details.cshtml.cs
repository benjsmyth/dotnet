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
    public class DetailsModel : PageModel
    {
        private readonly PassMan.Data.PassManContext _context;

        public DetailsModel(PassMan.Data.PassManContext context)
        {
            _context = context;
        }

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
    }
}
