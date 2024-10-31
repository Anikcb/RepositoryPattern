using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;

namespace RepositoryPattern.Data
{
    public class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext (DbContextOptions<RepositoryPatternContext> options)
            : base(options)
        {
        }

        public DbSet<RepositoryPattern.Models.Student> Student { get; set; } = default!;
    }
}
