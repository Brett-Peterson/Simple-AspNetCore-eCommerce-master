using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    public class CommerceContext : DbContext
    {
        public CommerceContext(DbContextOptions<CommerceContext> options)
            : base(options)
        {

        }

        //Add all Models (classes) as a DbSet that need
        //to be tracked by the database
        public DbSet<Member> Members { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
