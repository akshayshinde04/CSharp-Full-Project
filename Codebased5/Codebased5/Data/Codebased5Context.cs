using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Codebased5.Models;

namespace Codebased5.Data
{
    public class Codebased5Context : DbContext
    {
        public Codebased5Context (DbContextOptions<Codebased5Context> options)
            : base(options)
        {
        }

        public DbSet<Codebased5.Models.Student>? Student { get; set; }
    }
}
