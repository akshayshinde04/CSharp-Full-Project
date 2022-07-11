using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_Evaluation_Test.Models;

namespace Final_Evaluation_Test.Data
{
    public class Final_Evaluation_TestContext : DbContext
    {
        public Final_Evaluation_TestContext (DbContextOptions<Final_Evaluation_TestContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Evaluation_Test.Models.Employee>? Employee { get; set; }
    }
}
