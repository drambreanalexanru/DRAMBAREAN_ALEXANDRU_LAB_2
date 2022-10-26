using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DRAMBAREAN_ALEXANDRU_LAB_2.Models;

namespace DRAMBAREAN_ALEXANDRU_LAB_2.Data
{
    public class DRAMBAREAN_ALEXANDRU_LAB_2Context : DbContext
    {
        public DRAMBAREAN_ALEXANDRU_LAB_2Context (DbContextOptions<DRAMBAREAN_ALEXANDRU_LAB_2Context> options)
            : base(options)
        {
        }

        public DbSet<DRAMBAREAN_ALEXANDRU_LAB_2.Models.Book> Book { get; set; } = default!;

        public DbSet<DRAMBAREAN_ALEXANDRU_LAB_2.Models.Publisher> Publisher { get; set; }

        public DbSet<DRAMBAREAN_ALEXANDRU_LAB_2.Models.Category> Category { get; set; }
    }
}
