using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hritcu_DragosCristian_Lab2.Models;

namespace Hritcu_DragosCristian_Lab2.Data
{
    public class Hritcu_DragosCristian_Lab2Context : DbContext
    {
        public Hritcu_DragosCristian_Lab2Context (DbContextOptions<Hritcu_DragosCristian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Hritcu_DragosCristian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Hritcu_DragosCristian_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
