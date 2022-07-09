using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniProject2.Models;

namespace MiniProject2.Data
{
    public class MiniProject2Context : DbContext
    {
        public MiniProject2Context (DbContextOptions<MiniProject2Context> options)
            : base(options)
        {
        }

        public DbSet<MiniProject2.Models.Product>? Product { get; set; }
    }
}
