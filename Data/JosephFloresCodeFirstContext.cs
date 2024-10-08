using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JosephFloresCodeFirst.Models;

namespace JosephFloresCodeFirst.Data
{
    public class JosephFloresCodeFirstContext : DbContext
    {
        public JosephFloresCodeFirstContext (DbContextOptions<JosephFloresCodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<JosephFloresCodeFirst.Models.Burger> Burger { get; set; } = default!;
    }
}
