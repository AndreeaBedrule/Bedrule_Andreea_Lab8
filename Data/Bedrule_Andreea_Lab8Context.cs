using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bedrule_Andreea_Lab8.Models;

namespace Bedrule_Andreea_Lab8.Data
{
    public class Bedrule_Andreea_Lab8Context : DbContext
    {
        public Bedrule_Andreea_Lab8Context (DbContextOptions<Bedrule_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bedrule_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bedrule_Andreea_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
