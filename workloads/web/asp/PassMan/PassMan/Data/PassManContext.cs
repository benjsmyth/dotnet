using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PassMan.Models;

namespace PassMan.Data
{
    public class PassManContext : DbContext
    {
        public PassManContext (DbContextOptions<PassManContext> options)
            : base(options)
        {
        }

        public DbSet<PassMan.Models.Password> Password { get; set; } = default!;
    }
}
