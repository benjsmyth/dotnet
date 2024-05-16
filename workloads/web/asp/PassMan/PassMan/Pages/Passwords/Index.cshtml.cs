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
    public class IndexModel : PageModel
    {
        private readonly PassMan.Data.PassManContext _context;

        public IndexModel(PassMan.Data.PassManContext context)
        {
            _context = context;
        }

        public IList<Password> Password { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Password = await _context.Password.ToListAsync();
        }
    }
}
