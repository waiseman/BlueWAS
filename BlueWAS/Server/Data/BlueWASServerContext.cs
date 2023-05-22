using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlueWAS.Shared;

namespace BlueWAS.Server.Data
{
    public class BlueWASServerContext : DbContext
    {
        public BlueWASServerContext (DbContextOptions<BlueWASServerContext> options)
            : base(options)
        {
        }

        public DbSet<BlueWAS.Shared.Student> Student { get; set; } = default!;
    }
}
