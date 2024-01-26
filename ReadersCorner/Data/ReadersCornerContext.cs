using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReadersCorner.Models;

namespace ReadersCorner.Data
{
    public class ReadersCornerContext : DbContext
    {
        public ReadersCornerContext (DbContextOptions<ReadersCornerContext> options)
            : base(options)
        {
        }

        public DbSet<ReadersCorner.Models.User> User { get; set; } = default!;
    }
}
