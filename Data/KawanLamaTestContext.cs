using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KawanLamaTest.Model;

namespace KawanLamaTest.Data
{
    public class KawanLamaTestContext : DbContext
    {
        public KawanLamaTestContext (DbContextOptions<KawanLamaTestContext> options)
            : base(options)
        {
        }

        public DbSet<KawanLamaTest.Model.Employee> Employee { get; set; } = default!;
    }
}
